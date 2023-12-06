using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class AuthResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "data")]
        public TokenData Data { get; set; }
    }
}
