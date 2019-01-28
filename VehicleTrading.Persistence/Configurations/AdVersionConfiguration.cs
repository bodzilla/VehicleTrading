using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="AdVersion" />.
    /// </summary>
    internal sealed class AdVersionConfiguration : IEntityTypeConfiguration<AdVersion>
    {
        public void Configure(EntityTypeBuilder<AdVersion> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            builder.Property(x => x.Title).IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Slogan).IsRequired()
                .HasMaxLength(25);

            builder.Property(x => x.Description).IsRequired()
                .HasMaxLength(1000);

            // Ad version has one ad.
            // Ad has many AdVersions.
            builder.HasOne(x => x.Ad);
        }
    }
}
