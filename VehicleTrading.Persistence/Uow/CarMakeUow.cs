using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="ICarMakeUow" />
    public sealed class CarMakeUow : GenericUow, ICarMakeUow
    {
        /// <inheritdoc />
        public CarMakeUow(DbContext context) : base(context) => CarMakes = new CarMakeRepository(context);

        /// <inheritdoc />
        public ICarMakeRepository CarMakes { get; }
    }
}
