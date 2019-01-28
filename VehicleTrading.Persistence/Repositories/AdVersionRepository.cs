using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="IAdVersionRepository" />
    public sealed class AdVersionRepository : GenericRepository<AdVersion>, IAdVersionRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public AdVersionRepository(DbContext context)
            : base(context)
        {
        }
    }
}
