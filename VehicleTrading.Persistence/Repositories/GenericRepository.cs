﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Contracts.Repositories;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc />
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly DbContext Context;

        #region Default Constructor

        /// <inheritdoc />
        public GenericRepository(DbContext context) => Context = context;

        #endregion

        #region Asynchronous Methods

        /// <inheritdoc />
        public async Task AddAsync(params T[] entities)
        {
            foreach (T entity in entities) await Context.Set<T>().AddAsync(entity);
        }

        /// <inheritdoc />
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> where) => await GetAsync(where) != null;

        /// <inheritdoc />
        public async Task<T> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            T entity = await query.FirstOrDefaultAsync(where);
            return entity;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            IEnumerable<T> entities = await query.ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            IEnumerable<T> entities = await query.Where(where).ToListAsync();
            return entities;
        }

        #endregion

        #region Synchronous Methods

        /// <inheritdoc />
        public void Add(params T[] entities)
        {
            foreach (T entity in entities) Context.Set<T>().Add(entity);
        }

        /// <inheritdoc />
        public bool Exists(Expression<Func<T, bool>> where) => Get(where) != null;

        /// <inheritdoc />
        public T Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            T entity = query.FirstOrDefault(where);
            return entity;
        }

        /// <inheritdoc />
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            IEnumerable<T> entities = query.ToList();
            return entities;
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            IQueryable<T> query = Context.Set<T>();
            query = navigationProperties.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            IEnumerable<T> entities = query.Where(where).ToList();
            return entities;
        }

        #endregion

        #region Universal Methods

        /// <inheritdoc />
        public void Remove(params T[] entities)
        {
            foreach (T entity in entities) Context.Set<T>().Remove(entity);
        }

        /// <inheritdoc />
        public void SetInactive(params T[] entities)
        {
            foreach (T entity in entities) entity.EntityActive = false;
        }

        #endregion
    }
}
