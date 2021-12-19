using System;

namespace Azihub.GlobalData.Base.TimeZones.Exceptions
{
    public class InvalidTimeZoneCode : Exception
    {
        public InvalidTimeZoneCode(string code) : base($"Invalid Time Zone code was provided: {code}") { }
    }
}
