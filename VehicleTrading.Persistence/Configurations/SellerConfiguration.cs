using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="Seller" />.
    /// </summary>
    internal sealed class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            builder.Property(x => x.Forename).IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.Surname).IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.PostCode).IsRequired()
                .HasMaxLength(10);

            // Seller has many ads.
            // Ad has one seller.
            builder.HasMany(x => x.Ads);

            // Seller has one user.
            // User has many sellers.
            builder.HasOne(x => x.User);
        }
    }
}
