using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Request
{
    public class UpdateEmployeeRequest
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "employee")]
        public Employee Employee { get; set; }
    }
}
