using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class AdVersionService : IAdVersionService
    {
        private readonly IAdVersionUow _unitOfWork;

        /// <inheritdoc />
        public AdVersionService(IAdVersionUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
