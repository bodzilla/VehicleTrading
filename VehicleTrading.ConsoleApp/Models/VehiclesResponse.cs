using System.Collections.Generic;
using Newtonsoft.Json;

namespace VehicleTrading.ConsoleApp.Models
{
    public sealed class VehiclesResponse
    {
        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Models { get; set; }
    }
}
