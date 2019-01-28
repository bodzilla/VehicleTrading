using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="User"/> unit of work.
    /// </summary>
    public interface IUserUow : IUow
    {
        IUserRepository Users { get; }
    }
}
