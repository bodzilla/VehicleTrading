using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelUow _unitOfWork;

        /// <inheritdoc />
        public CarModelService(ICarModelUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
