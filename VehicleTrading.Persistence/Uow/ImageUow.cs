using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Contracts.Uow;
using VehicleTrading.Persistence.Repositories;

namespace VehicleTrading.Persistence.Uow
{
    /// <inheritdoc cref="IImageUow" />
    public sealed class ImageUow : GenericUow, IImageUow
    {
        /// <inheritdoc />
        public ImageUow(DbContext context) : base(context) => Images = new ImageRepository(context);

        /// <inheritdoc />
        public IImageRepository Images { get; }
    }
}
