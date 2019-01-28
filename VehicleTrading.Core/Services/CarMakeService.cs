using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class CarMakeService : ICarMakeService
    {
        private readonly ICarMakeUow _unitOfWork;

        /// <inheritdoc />
        public CarMakeService(ICarMakeUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
