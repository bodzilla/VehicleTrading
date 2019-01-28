using System;
using VehicleTrading.Core.Contracts;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The child advert version.
    /// </summary>
    public sealed class AdVersion : IEntity
    {
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
        /// The title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The slogan.
        /// </summary>
        public string Slogan { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The mileage.
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// The price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Ad"/> id.
        /// </summary>
        public int AdId { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Ad"/>.
        /// </summary>
        public Ad Ad { get; set; }

        #endregion
    }
}
