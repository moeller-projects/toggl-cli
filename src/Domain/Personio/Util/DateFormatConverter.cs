using Moeller.Toggl.Cli.Domain.Personio.Common;
using Newtonsoft.Json.Converters;

namespace Moeller.Toggl.Cli.Domain.Personio.Util
{
    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter() : this(Constants.DATE_FORMAT) { }
        public DateFormatConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
