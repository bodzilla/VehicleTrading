using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Contracts.Services
{
    /// <summary>
    /// The <see cref="Settings"/> serivce.
    /// </summary>
    public interface ISettingsService
    {
        /// <summary>
        /// Gets all <see cref="Settings"/>.
        /// </summary>
        /// <returns></returns>
        Task<IDictionary<string, string>> GetAllAsync();
    }
}
