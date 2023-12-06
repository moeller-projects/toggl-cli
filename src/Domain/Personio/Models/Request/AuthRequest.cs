using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Request
{
    public class AuthRequest
    {
        [JsonProperty(PropertyName = "client_id")]
        public string ClientId { get; set; }

        [JsonProperty(PropertyName = "client_secret")]
        public string ClientSecret { get; set; }
    }
}
