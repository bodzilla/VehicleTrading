using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class SellerService : ISellerService
    {
        private readonly ISellerUow _unitOfWork;

        /// <inheritdoc />
        public SellerService(ISellerUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
