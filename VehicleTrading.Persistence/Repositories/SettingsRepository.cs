using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="ISettingsRepository" />
    public sealed class SettingsRepository : GenericRepository<Settings>, ISettingsRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public SettingsRepository(DbContext context)
            : base(context)
        {
        }
    }
}
