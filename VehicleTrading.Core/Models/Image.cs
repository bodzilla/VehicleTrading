using System;
using VehicleTrading.Core.Contracts;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The image class.
    /// </summary>
    public sealed class Image : IEntity
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public DateTime EntityCreated { get; set; }

        /// <inheritdoc />
        public bool EntityActive { get; set; }

        /// <inheritdoc />
        public byte[] EntityVersion { get; set; }

        /// <summary>
        /// The file name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The link to the physical location of the image.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Ad"/> id.
        /// </summary>
        public string AdId { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Ad"/>.
        /// </summary>
        public Ad Ad { get; set; }
    }
}
