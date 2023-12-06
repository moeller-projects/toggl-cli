using Moeller.Toggl.Cli.Domain.Personio.Models.Attributes;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class GetTimeOffTypesResponse : BasePagedListResponse<TimeOffTypeAttributes, TimeOffType>
    {
        protected override Func<TimeOffTypeAttributes, TimeOffType> Converter => x => x.ToTimeOffType();
    }
}
