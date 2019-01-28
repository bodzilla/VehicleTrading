using System;
using VehicleTrading.Core.Contracts;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The application settings.
    /// </summary>
    public sealed class Settings : IEntity
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
        /// The key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The value.
        /// </summary>
        public string Value { get; set; }

        #endregion
    }
}
