using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Repositories
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="CarMake"/> repository.
    /// </summary>
    public interface ICarMakeRepository : IRepository<CarMake>
    {
        /// <summary>
        /// Get <see cref="CarMake"/> using the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<CarMake> GetAsync(string name);

        /// <summary>
        /// Get all <see cref="CarMake"/>s.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CarMake>> GetAllAsync();

        /// <summary>
        /// Get all specific fields for <see cref="CarMake"/>s.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<dynamic>> GetAllIdsAndNamesAsync();

        /// <summary>
        /// Check if the <see cref="CarMake"/> name exists.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<bool> NameExistsAsync(string name);

        /// <summary>
        /// Create a new <see cref="CarMake"/>.
        /// </summary>
        /// <param name="carMakes"></param>
        /// <returns></returns>
        Task Create(params CarMake[] carMakes);
    }
}
