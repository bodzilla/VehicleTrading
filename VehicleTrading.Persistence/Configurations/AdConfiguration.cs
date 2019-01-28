using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Enums;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="Ad" />.
    /// </summary>
    internal sealed class AdConfiguration : IEntityTypeConfiguration<Ad>
    {
        public void Configure(EntityTypeBuilder<Ad> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);
            builder.HasIndex(x => x.Guid).IsUnique();
            builder.Property(x => x.Email).HasMaxLength(255);
            builder.Property(x => x.PhonePrimary).HasMaxLength(20);
            builder.Property(x => x.PhoneSecondary).HasMaxLength(20);
            builder.Property(x => x.CategoryType).HasDefaultValue(CategoryType.None);
            builder.Property(x => x.AdType).HasDefaultValue(AdType.Standard);
            builder.Property(x => x.AdStatusType).HasDefaultValue(AdStatusType.Processing);

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            builder.Property(x => x.PostCode).IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.RegistrationPlate).IsRequired()
                .HasMaxLength(10);

            // Ad has many images.
            // Image has one ad.
            builder.HasMany(x => x.Images);

            // Ad has many ad versions.
            // Ad versions has one ad.
            builder.HasMany(x => x.AdVersions);

            // Ad has one car model.
            // Car model has many ads.
            builder.HasOne(x => x.CarModel);

            // Ad has one Seller.
            // Seller model has many ads.
            builder.HasOne(x => x.Seller);
        }
    }
}
