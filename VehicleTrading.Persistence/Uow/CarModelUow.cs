using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="ICarModelUow" />
    public sealed class CarModelUow : GenericUow, ICarModelUow
    {
        /// <inheritdoc />
        public CarModelUow(DbContext context) : base(context) => CarModels = new CarModelRepository(context);

        /// <inheritdoc />
        public ICarModelRepository CarModels { get; }
    }
}
