using System.Threading.Tasks;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Services
{
    /// <summary>
    /// The <see cref="Seller"/> serivce.
    /// </summary>
    public interface ISellerService
    {
        /// <summary>
        /// Creates <see cref="Seller"/>s.
        /// </summary>
        /// <param name="sellers"></param>
        /// <returns></returns>
        Task CreateAsync(params Seller[] sellers);
    }
}
