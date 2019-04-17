using System.Threading.Tasks;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelUow _unitOfWork;

        /// <inheritdoc />
        public CarModelService(ICarModelUow unitOfWork) => _unitOfWork = unitOfWork;

        /// <inheritdoc />
        public async Task<bool> NameExistsAsync(string name) => await _unitOfWork.CarModels.NameExistsAsync(name);

        /// <inheritdoc />
        public async Task CreateAsync(params CarModel[] carModels)
        {
            await _unitOfWork.CarModels.CreateAsync(carModels);
            await _unitOfWork.CompleteAsync();
        }
    }
}
