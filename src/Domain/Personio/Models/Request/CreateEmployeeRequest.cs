using Newtonsoft.Json;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Request
{
    public class CreateEmployeeRequest
    {
        [JsonProperty(PropertyName = "employee")]
        public Employee Employee { get; set; }
    }
}
