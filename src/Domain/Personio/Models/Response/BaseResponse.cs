using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class BaseResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}
