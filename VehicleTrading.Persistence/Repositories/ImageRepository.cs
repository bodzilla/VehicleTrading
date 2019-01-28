using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="IImageRepository" />
    public sealed class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public ImageRepository(DbContext context)
            : base(context)
        {
        }
    }
}
