using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="CarModel" />.
    /// </summary>
    internal sealed class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);
            builder.Property(x => x.Name).HasMaxLength(100);

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            builder.HasIndex(x => x.Name).IsUnique();

            // Car model has many ads.
            // Ad has one car model.
            builder.HasMany(x => x.Ads);

            // Car model has one car make.
            // Car make has many car models.
            builder.HasOne(x => x.CarMake);
        }
    }
}
