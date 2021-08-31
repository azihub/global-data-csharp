using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.Timezones.Exceptions
{
    public class InvalidTimeZoneCode : Exception
    {
        public InvalidTimeZoneCode(string code) : base($"Invalid Time Zone code was provided: {code}") { }
    }
}
