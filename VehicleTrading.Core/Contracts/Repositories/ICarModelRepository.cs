using System.Threading.Tasks;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Repositories
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="CarModel"/> repository.
    /// </summary>
    public interface ICarModelRepository : IRepository<CarModel>
    {
        /// <summary>
        /// Check if the <see cref="CarModel"/> name exists.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<bool> NameExistsAsync(string name);

        /// <summary>
        /// Create a new <see cref="CarModel"/>.
        /// </summary>
        /// <param name="carModels"></param>
        /// <returns></returns>
        Task CreateAsync(params CarModel[] carModels);
    }
}
