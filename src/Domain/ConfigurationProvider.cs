using System.Diagnostics;
using JsonFlatFileDataStore;
using Moeller.Toggl.Cli.Infrastructure;

namespace Moeller.Toggl.Cli.Domain;

public class ConfigurationProvider
{
    private readonly IDataStore _Store;

    public ConfigurationProvider(IDataStore store)
    {
        _Store = store ?? throw new ArgumentNullException(nameof(store));
    }

    public TogglCliSettings Get()
    {
        try
        {
            return _Store.GetItem<TogglCliSettings>(nameof(TogglCliSettings));
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null;
        }
    }

    public Task<bool> SetAsync(TogglCliSettings settings)
    {
        return _Store.ReplaceItemAsync(nameof(TogglCliSettings), settings, true);
    }
}