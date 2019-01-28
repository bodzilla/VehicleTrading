using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class UserService : IUserService
    {
        private readonly IUserUow _unitOfWork;

        /// <inheritdoc />
        public UserService(IUserUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
