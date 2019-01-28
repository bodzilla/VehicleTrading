using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Persistence.Configurations
{
    /// <inheritdoc />
    /// <summary>
    /// The database configuration for <see cref="Image" />.
    /// </summary>
    internal sealed class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.EntityCreated).HasDefaultValueSql("getdate()");
            builder.Property(x => x.EntityActive).HasDefaultValue(true);
            builder.HasIndex(x => x.Link).IsUnique();
            builder.Property(x => x.Name).HasDefaultValue(DateTime.Now.ToString("yyyyMMddhmmtt"));

            builder.Property(x => x.EntityVersion).IsConcurrencyToken()
                .IsRowVersion();

            // Image has one ad.
            // Ad has many images.
            builder.HasOne(x => x.Ad);
        }
    }
}
