namespace Moeller.Toggl.Cli.Domain.Personio.Models.Request
{
    public class GetTimeOffTypesRequest
    {
        public int Limit { get; set; } = 200;
        public int Offset { get; set; }
    }
}
