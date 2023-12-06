using Moeller.Toggl.Cli.Domain.Personio.Models.Attributes;
using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class GetTimeOffPeriodResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "data")]
        public TypeAndAttributesObject<TimeOffPeriodAttributes> Data { get; set; }
    }
}
