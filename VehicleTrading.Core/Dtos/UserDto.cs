using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Models;

namespace VehicleTrading.Core.Dtos
{
    /// <inheritdoc />
    /// <summary>
    /// The <see cref="User" /> data transfer object.
    /// </summary>
    public sealed class UserDto : IDto
    {
        public int Id { get; set; }

        public DateTime EntityCreated { get; set; }

        public string Email { get; set; }

        public IEnumerable<Seller> Sellers { get; set; }
    }
}
