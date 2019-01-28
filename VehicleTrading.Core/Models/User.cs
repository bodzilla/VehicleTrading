using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using VehicleTrading.Core.Contracts;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc cref="IdentityUser" />
    /// <summary>
    /// The application user.
    /// </summary>
    public sealed class User : IdentityUser<int>, IEntity
    {
        #region Default Constructor

        /// <inheritdoc />
        public User() => Sellers = new HashSet<Seller>();

        #endregion

        #region Public Properties

        /// <inheritdoc cref="IEntity" />
        public override int Id { get; set; }

        /// <inheritdoc />
        public DateTime EntityCreated { get; set; }

        /// <inheritdoc />
        public bool EntityActive { get; set; }

        /// <inheritdoc />
        public byte[] EntityVersion { get; set; }

        /// <summary>
        /// The associated list of the <see cref="User"/>'s <see cref="Seller"/>s.
        /// </summary>
        public ICollection<Seller> Sellers { get; set; }

        #endregion
    }
}
