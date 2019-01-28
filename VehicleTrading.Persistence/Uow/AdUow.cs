using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="IAdUow" />
    public sealed class AdUow : GenericUow, IAdUow
    {
        /// <inheritdoc />
        public AdUow(DbContext context) : base(context) => Ads = new AdRepository(context);

        /// <inheritdoc />
        public IAdRepository Ads { get; }
    }
}
