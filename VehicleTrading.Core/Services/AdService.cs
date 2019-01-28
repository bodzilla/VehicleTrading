using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class AdService : IAdService
    {
        private readonly IAdUow _unitOfWork;

        /// <inheritdoc />
        public AdService(IAdUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
