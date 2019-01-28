using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="IUserUow" />
    public sealed class UserUow : GenericUow, IUserUow
    {
        /// <inheritdoc />
        public UserUow(DbContext context) : base(context) => Users = new UserRepository(context);

        /// <inheritdoc />
        public IUserRepository Users { get; }
    }
}
