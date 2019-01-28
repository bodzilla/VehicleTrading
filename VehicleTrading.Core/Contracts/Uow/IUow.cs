﻿using System;
using System.Threading.Tasks;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The base unit of work interface where all units of work inherit from.
    /// </summary>
    public interface IUow : IDisposable
    {
        /// <summary>
        /// Persist changes to the database.
        /// </summary>
        /// <returns></returns>
        Task CompleteAsync();

        /// <summary>
        /// Persist changes to the database.
        /// </summary>
        /// <returns></returns>
        void Complete();
    }
}
