using Microsoft.AspNetCore.Identity;

namespace VehicleTrading.Core.Models
{
    /// <inheritdoc />
    /// <summary>
    /// The application role.
    /// </summary>
    public sealed class Role : IdentityRole<int>
    {
        #region Public Properties

        /// <summary>
        /// The description of this role.
        /// </summary>
        public string Description { get; set; }

        #endregion
    }
}
