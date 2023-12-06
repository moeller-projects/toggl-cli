namespace Moeller.Toggl.Cli.Infrastructure;

public class TogglCliSettings
{
    public TogglCliSettings()
    {
        
    }

    public TogglCliSettings(TogglSettings togglSettings, PersonioSettings personioSettings)
    {
        TogglSettings = togglSettings;
        PersonioSettings = personioSettings;
    }

    public TogglSettings TogglSettings { get; set; }
    public PersonioSettings PersonioSettings { get; set; }
}

public class TogglSettings
{
    public string ApiToken { get; set; }
    public int DefaultWorkSpace { get; set; }
}

public class PersonioSettings
{
    public string EmployeeName { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public int EmployeeId { get; set; }
}