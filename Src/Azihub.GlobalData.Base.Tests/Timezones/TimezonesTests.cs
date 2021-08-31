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
    public class TimezonesTests : TestBase
    {
        public TimezonesTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void TimezonesIanaTests()
        {
            var tzCollection = TZConvert.KnownIanaTimeZoneNames;
            foreach (string timezone in tzCollection)
            {
                Output.WriteLine("public const string "+timezone.Replace("/","__")
                    .ToConstantCase(true)+" = \""+timezone+"\";");
            }
        }
        
        [Fact]
        public void TimezonesWindowsTests()
        {
            var tzCollection = TZConvert.KnownWindowsTimeZoneIds;
            foreach (string timezone in tzCollection)
            {
                Output.WriteLine("public const string "+timezone.Replace("/","__")
                    .ToConstantCase(true)+" = \""+timezone+"\";");
            }
        }

        [Fact]
        public void DotNetTimezoneConstTest()
        {
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                Output.WriteLine("public const string "+z.Id.Replace("/","__")
                    .ToConstantCase(true)+" = \""+z.Id+"\";");
                
            }
        }
        
        [Fact]
        public void DotNetTimezoneStaticTest()
        {
            // GENERATE: 
            // public static TimeZoneId DatelineStandardTime => TimeZoneId.FromString(TimeZoneConsts.DATELINE_STANDARD_TIME);
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                Output.WriteLine("public static TimeZoneId "+z.Id.ToPascalCase()+" => TimeZoneId.FromString(TimeZoneConsts."+z.Id.ToConstantCase()+");");
                
            }
        }
        
        [Fact]
        public void DotNetAbrTimezoneTest()
        {
            Output.WriteLine("Total timezone count: " + TimeZoneInfo.GetSystemTimeZones().Count);
            Dictionary<string, TimeZoneInfo> dict = new();
            string abr = "";
            bool added = false;
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                Output.WriteLine(GetAbbreviation(z.Id));
                Output.WriteLine(z.DisplayName+"|"+ z.Id + "|"+z.StandardName+"|"+z.BaseUtcOffset);
                added = false;
                do
                {
                    if (z.Id.Substring(0, 3) == "UTC")
                        abr = z.Id;
                    else
                        abr = GetAbbreviation(z.Id);

                    
                    if (!dict.ContainsKey(abr))
                    {
                        dict.TryAdd(abr, z);
                        added = true;
                    }
                    else
                    {
                        int i = 2;
                        do
                        {
                            if (!dict.ContainsKey(abr + i))
                            {
                                dict.TryAdd(abr, z);
                                added = true;
                                break;
                            }

                            i++;
                        } while (true);
                    }                        

                } while (added == false);
            }
        }

        private string GetAbbreviation(string text)
        {
            const string pattern = @"((?<=^|\s)(\w{1})|([A-Z]))";
            return string.Join(string.Empty, Regex.Matches(text, pattern).OfType<Match>().Select(x => x.Value.ToUpper()));

        }
    }
}
