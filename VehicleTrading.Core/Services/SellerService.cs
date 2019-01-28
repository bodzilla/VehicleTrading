using System.Threading.Tasks;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class SellerService : ISellerService
    {
        private readonly ISellerUow _unitOfWork;

        /// <inheritdoc />
        public SellerService(ISellerUow unitOfWork) => _unitOfWork = unitOfWork;

        /// <inheritdoc />
        public async Task CreateAsync(params Seller[] sellers)
        {
            foreach (var seller in sellers) await _unitOfWork.Sellers.AddAsync(seller);
            await _unitOfWork.CompleteAsync();
        }
    }
}
