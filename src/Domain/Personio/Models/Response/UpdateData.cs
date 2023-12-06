using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class UpdateData
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
    }
}
