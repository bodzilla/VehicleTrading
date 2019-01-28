using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class ImageService : IImageService
    {
        private readonly IImageUow _unitOfWork;

        /// <inheritdoc />
        public ImageService(IImageUow unitOfWork) => _unitOfWork = unitOfWork;
    }
}
