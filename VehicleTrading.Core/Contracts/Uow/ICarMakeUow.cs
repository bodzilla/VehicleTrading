using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="CarMake"/> unit of work.
    /// </summary>
    public interface ICarMakeUow : IUow
    {
        ICarMakeRepository CarMakes { get; }
    }
}
