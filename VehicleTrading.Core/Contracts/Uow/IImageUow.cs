using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="Image"/> unit of work.
    /// </summary>
    public interface IImageUow : IUow
    {
        IImageRepository Images { get; }
    }
}
