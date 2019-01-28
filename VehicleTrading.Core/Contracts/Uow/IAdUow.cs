using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="Ad"/> unit of work.
    /// </summary>
    public interface IAdUow : IUow
    {
        IAdRepository Ads { get; }
    }
}
