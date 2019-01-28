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
    }
}
