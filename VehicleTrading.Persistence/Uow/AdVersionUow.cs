using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="IAdVersionUow" />
    public sealed class AdVersionUow : GenericUow, IAdVersionUow
    {
        /// <inheritdoc />
        public AdVersionUow(DbContext context) : base(context) => AdVersions = new AdVersionRepository(context);

        /// <inheritdoc />
        public IAdVersionRepository AdVersions { get; }
    }
}
