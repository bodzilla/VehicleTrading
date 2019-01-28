using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Enums;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The seller.
    /// </summary>
    public sealed class Seller : IEntity
    {
        #region Default Constructor

        /// <inheritdoc />
        public Seller() => Ads = new HashSet<Ad>();

        #endregion

        #region Public Properties

        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public DateTime EntityCreated { get; set; }

        /// <inheritdoc />
        public bool EntityActive { get; set; }

        /// <inheritdoc />
        public byte[] EntityVersion { get; set; }

        /// <summary>
        /// The seller's forename.
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// The seller's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The seller's post code.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// The seller's type.
        /// </summary>
        public SellerType SellerType { get; set; }

        /// <summary>
        /// The associated <see cref="User"/> id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The associated <see cref="Models.User"/>.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The associated list of <see cref="Ad"/>s.
        /// </summary>
        public ICollection<Ad> Ads { get; set; }

        #endregion
    }
}
