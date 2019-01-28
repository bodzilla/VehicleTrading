using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="CarModel"/> unit of work.
    /// </summary>
    public interface ICarModelUow : IUow
    {
        ICarModelRepository CarModels { get; }
    }
}
