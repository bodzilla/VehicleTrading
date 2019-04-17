using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class CarMakeService : ICarMakeService
    {
        private readonly ICarMakeUow _unitOfWork;

        /// <inheritdoc />
        public CarMakeService(ICarMakeUow unitOfWork) => _unitOfWork = unitOfWork;

        /// <inheritdoc />
        public async Task<CarMake> GetAsync(string name) => await _unitOfWork.CarMakes.GetAsync(name);

        /// <inheritdoc />
        public async Task<IEnumerable<CarMake>> GetAllAsync() => await _unitOfWork.CarMakes.GetAllAsync();

        /// <inheritdoc />
        public async Task<IEnumerable<dynamic>> GetAllIdsAndNamesAsync() => await _unitOfWork.CarMakes.GetAllIdsAndNamesAsync();

        /// <inheritdoc />
        public async Task<bool> NameExistsAsync(string name) => await _unitOfWork.CarMakes.NameExistsAsync(name);

        /// <inheritdoc />
        public async Task CreateAsync(params CarMake[] carMakes)
        {
            await _unitOfWork.CarMakes.Create(carMakes);
            await _unitOfWork.CompleteAsync();
        }
    }
}
