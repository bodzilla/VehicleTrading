using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="ICarMakeRepository" />
    public sealed class CarMakeRepository : GenericRepository<CarMake>, ICarMakeRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public CarMakeRepository(DbContext context)
            : base(context)
        {
        }

        /// <inheritdoc />
        public async Task<CarMake> GetAsync(string name) => await GetAsync(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

        /// <inheritdoc />
        public async Task<IEnumerable<CarMake>> GetAllAsync() => await GetAllAsync(x => x.CarModels);

        /// <inheritdoc />
        public async Task<IEnumerable<dynamic>> GetAllIdsAndNamesAsync() =>
            await GetAllSubsetAsync(x => new { x.Id, x.Name, Models = x.CarModels.Select(y => new { y.Id, y.Name }) });

        /// <inheritdoc />
        public async Task<bool> NameExistsAsync(string name) => await ExistsAsync(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

        /// <inheritdoc />
        public async Task Create(params CarMake[] carMakes) => await AddAsync(carMakes);
    }
}
