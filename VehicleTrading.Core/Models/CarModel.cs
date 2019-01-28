using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Enums;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The car model.
    /// </summary>
    public sealed class CarModel : IEntity
    {
        #region Default Constructor

        /// <inheritdoc />
        public CarModel() => Ads = new HashSet<Ad>();

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
        /// The name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The car model's <see cref="Enums.VehicleType"/>.
        /// </summary>
        public VehicleType VehicleType { get; set; }

        /// <summary>
        /// The associated <see cref="CarMake"/> id.
        /// </summary>
        public int CarMakeId { get; set; }

        /// <summary>
        /// The associated list of <see cref="Ad"/>s.
        /// </summary>
        public ICollection<Ad> Ads { get; set; }

        /// <summary>
        /// The associated <see cref="CarMake"/>.
        /// </summary>
        public CarMake CarMake { get; set; }

        #endregion
    }
}