using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts.Repositories;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Repositories
{
    /// <inheritdoc cref="ISellerRepository" />
    public sealed class SellerRepository : GenericRepository<Seller>, ISellerRepository
    {
        /// <summary>
        /// Gets the base context.
        /// </summary>
        public DbContext DbContext => Context;

        /// <inheritdoc />
        public SellerRepository(DbContext context)
            : base(context)
        {
        }
    }
}
