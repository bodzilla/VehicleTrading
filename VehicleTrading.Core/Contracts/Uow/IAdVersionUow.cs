using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="AdVersion"/> unit of work.
    /// </summary>
    public interface IAdVersionUow : IUow
    {
        IAdVersionRepository AdVersions { get; }
    }
}
