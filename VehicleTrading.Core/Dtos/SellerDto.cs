using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Enums;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Dtos
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="Seller" /> data transfer object.
    /// </summary>
    public sealed class SellerDto : IDto
    {
        public int Id { get; set; }

        public DateTime EntityCreated { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string PostCode { get; set; }

        public SellerType SellerType { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Ad> Ads { get; set; }
    }
}
