using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class DeleteData
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
