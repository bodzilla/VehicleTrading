using VehicleTrading.Core.Contracts.Repositories;

namespace VehicleTrading.Core.Contracts.Uow
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="Models.Settings"/> unit of work.
    /// </summary>
    public interface ISettingsUow : IUow
    {
        ISettingsRepository Settings { get; }
    }
}
