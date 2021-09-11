using Azihub.Utilities.Base.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azihub.Utilities.Base.Extensions.String;
using TimeZoneConverter;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.Timezones
{
    public class IanaTimezonesTests : TestBase
    {
        public IanaTimezonesTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TimezonesIanaTests()
        {
            ICollection<string> tzCollection = TZConvert.KnownIanaTimeZoneNames;
            foreach (string timezone in tzCollection)
            {
                try
                {
                    Output.WriteLine(timezone + " => " + TZConvert.IanaToWindows(timezone));
                }
                catch (InvalidTimeZoneException)
                {
                    Output.WriteLine(timezone + "=>" + "MISSING !!!");
                }
            }
        }
        
        [Fact]
        public void TimezonesMissingIanaTests()
        {
            ICollection<string> tzCollection = TZConvert.KnownIanaTimeZoneNames;
            foreach (string timezone in tzCollection)
            {
                try
                {
                    TZConvert.IanaToWindows(timezone);
                }
                catch (InvalidTimeZoneException)
                {
                    Output.WriteLine(timezone + "=>" + "MISSING !!!");
                }
            }
        }

        [Fact]
        public void Test()
        {
            // Microsoft.AspNetCore.Authentication.JwtBearer
        }
    }
}
