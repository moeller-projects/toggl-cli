using Moeller.Toggl.Cli.Domain.Personio.Models.Attributes;

namespace Moeller.Toggl.Cli.Domain.Personio.Models.Response
{
    public class GetEmployeesResponse : BasePagedListResponse<EmployeeAttributes, Employee>
    {
        protected override Func<EmployeeAttributes, Employee> Converter => x => x.ToEmployee();
    }
}
