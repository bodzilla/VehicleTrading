using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="ICarModelRepository" />
    public sealed class CarModelRepository : GenericRepository<CarModel>, ICarModelRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public CarModelRepository(DbContext context)
            : base(context)
        {
        }

        /// <inheritdoc />
        public async Task<bool> NameExistsAsync(string name) => await ExistsAsync(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

        /// <inheritdoc />
        public async Task CreateAsync(params CarModel[] carModels) => await AddAsync(carModels);
    }
}
