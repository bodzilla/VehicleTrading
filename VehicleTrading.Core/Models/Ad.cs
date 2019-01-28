using System;
using System.Collections.Generic;
using VehicleTrading.Core.Contracts;
using VehicleTrading.Core.Enums;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The parent advert node.
    /// </summary>
    public sealed class Ad : IEntity
    {
        #region Default Constructor

        /// <inheritdoc />
        public Ad() => Images = new HashSet<Image>();

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
        /// The guid identifier.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// The primary contact phone number.
        /// </summary>
        public string PhonePrimary { get; set; }

        /// <summary>
        /// The secondary contact phone number.
        /// </summary>
        public string PhoneSecondary { get; set; }

        /// <summary>
        /// The email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The post code.
        /// </summary>
        public int PostCode { get; set; }

        /// <summary>
        /// The ad's <see cref="Enums.AdStatusType"/>.
        /// </summary>
        public AdStatusType AdStatusType { get; set; }

        /// <summary>
        /// The ad's <see cref="Enums.AdType"/>.
        /// </summary>
        public AdType AdType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.BodyType"/>.
        /// </summary>
        public BodyType BodyType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.TransmissionType"/>.
        /// </summary>
        public TransmissionType TransmissionType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.FuelType"/>.
        /// </summary>
        public FuelType FuelType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.DriveTrainType"/>.
        /// </summary>
        public DriveTrainType DriveTrainType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.ColorType"/>.
        /// </summary>
        public ColorType ColorType { get; set; }

        /// <summary>
        /// The vehicle's <see cref="Enums.CategoryType"/>.
        /// </summary>
        public CategoryType CategoryType { get; set; }

        /// <summary>
        /// The vehicle's year of make.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// The vehicle's engine size.
        /// </summary>
        public int EngineSize { get; set; }

        /// <summary>
        /// The vehicle's bhp.
        /// </summary>
        public int Bhp { get; set; }

        /// <summary>
        /// The vehicle's number of doors.
        /// </summary>
        public int Doors { get; set; }

        /// <summary>
        /// The vehicle's number of seats.
        /// </summary>
        public int Seats { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Seller"/> id.
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// The associated list of <see cref="Image"/>s.
        /// </summary>
        public ICollection<Image> Images { get; set; }

        /// <summary>
        /// The associated <see cref="Models.Seller"/>.
        /// </summary>
        public Seller Seller { get; set; }

        #endregion
    }
}
