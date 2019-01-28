using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Models;
using VehicleTrading.Persistence.Configurations;

namespace VehicleTrading.Persistence
{
    /// <inheritdoc cref="IdentityDbContext{TUser}" />
    /// <summary>
    /// The database context.
    /// </summary>
    public sealed class VehicleTradingContext : IdentityDbContext<User, Role, int>, IDbContext
    {
        /// <summary>
        /// All public db sets, the internal dbsets are inherited from <see cref="IdentityDbContext{TUser}"/>.
        /// </summary>
        #region Public Properties

        public DbSet<Settings> Settings { get; set; }

        public DbSet<CarMake> CarMakes { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Ad> Ads { get; set; }

        public DbSet<AdVersion> AdVersions { get; set; }

        public DbSet<Image> Images { get; set; }

        #endregion

        #region Default Constructor

        /// <inheritdoc />
        public VehicleTradingContext(DbContextOptions options)
            : base(options)
        {
        }

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// This method is run when the context is creating the model.
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Model Configurations

            builder.ApplyConfiguration(new SettingsConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new CarMakeConfiguration());
            builder.ApplyConfiguration(new CarModelConfiguration());
            builder.ApplyConfiguration(new AdConfiguration());
            builder.ApplyConfiguration(new AdVersionConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());

            #endregion
        }
    }
}
