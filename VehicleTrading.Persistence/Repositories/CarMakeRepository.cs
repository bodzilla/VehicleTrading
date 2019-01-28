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
    }
}
