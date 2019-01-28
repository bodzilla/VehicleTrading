using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="ISettingsUow" />
    public sealed class SettingsUow : GenericUow, ISettingsUow
    {
        /// <inheritdoc />
        public SettingsUow(DbContext context) : base(context) => Settings = new SettingsRepository(context);

        /// <inheritdoc />
        public ISettingsRepository Settings { get; }
    }
}
