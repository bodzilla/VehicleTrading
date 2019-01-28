using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="ISellerUow" />
    public sealed class SellerUow : GenericUow, ISellerUow
    {
        /// <inheritdoc />
        public SellerUow(DbContext context) : base(context) => Sellers = new SellerRepository(context);

        /// <inheritdoc />
        public ISellerRepository Sellers { get; }
    }
}
