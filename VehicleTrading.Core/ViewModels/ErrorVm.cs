namespace VehicleTrading.Core.ViewModels
{
    /// <summary>
    /// The error view model.
    /// </summary>
    public class ErrorVm
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
