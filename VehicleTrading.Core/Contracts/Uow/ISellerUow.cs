using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="Seller"/> unit of work.
    /// </summary>
    public interface ISellerUow : IUow
    {
        ISellerRepository Sellers { get; }
    }
}
