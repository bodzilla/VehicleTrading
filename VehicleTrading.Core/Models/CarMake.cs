using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The car make.
    /// </summary>
    public sealed class CarMake : IEntity
    {
        #region Default Constructor

        /// <inheritdoc />
        public CarMake() => CarModels = new HashSet<CarModel>();

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
        /// The associated list of <see cref="CarModel"/>s.
        /// </summary>
        public ICollection<CarModel> CarModels { get; set; }

        #endregion
    }
}