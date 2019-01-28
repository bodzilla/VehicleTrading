using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="CarMake" />.
    /// </summary>
    internal sealed class CarMakeConfiguration : IEntityTypeConfiguration<CarMake>
    {
        public void Configure(EntityTypeBuilder<CarMake> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);
            builder.Property(x => x.Name).HasMaxLength(100);

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            builder.HasIndex(x => x.Name).IsUnique();

            // Car make has many car models.
            // Car model has one car make.
            builder.HasMany(x => x.CarModels);
        }
    }
}
