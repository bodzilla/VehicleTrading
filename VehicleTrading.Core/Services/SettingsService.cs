using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTrading.Core.Contracts.Services;
using VehicleTrading.Core.Contracts.Uow;

namespace VehicleTrading.Core.Services
{
    /// <inheritdoc />
    public class SettingsService : ISettingsService
    {
        private readonly ISettingsUow _unitOfWork;

        /// <inheritdoc />
        public SettingsService(ISettingsUow unitOfWork) => _unitOfWork = unitOfWork;

        /// <inheritdoc />
        public async Task<IDictionary<string, string>> GetAllAsync()
        {
            var settings = await _unitOfWork.Settings.GetAllAsync();
            return settings.ToDictionary(setting => setting.Key, setting => setting.Value);
        }
    }
}
