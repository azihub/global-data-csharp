using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using static System.Environment;
using NoobsMuc.Coinmarketcap.Client;
using CoinCurrency = NoobsMuc.Coinmarketcap.Client.Currency;
using System.IO;
using GlobalData.Currency;
using GlobalData.Country;
using System.Globalization;

namespace GlobalData.Tests
{
    public class GdCurrencyTests
    {
        private readonly ITestOutputHelper _output;
        public GdCurrencyTests(ITestOutputHelper output)
        {
            _output = output;
            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();

        }

        [Theory]
        [InlineData(Iso3FiatCodes.USD, Iso2Codes.US)]
        [InlineData(Iso3FiatCodes.EUR, Iso2Codes.Netherlands_The)]
        [InlineData(Iso3FiatCodes.IRR, Iso2Codes.Iran)]
        [InlineData(Iso3FiatCodes.MYR, Iso2Codes.Malaysia)]
        public void GetGdCurrencyFiat(string code, string expectedCountryCodeStr)
        {
            // Native .NET data has missing information about the Native Name
            // string[] rather than char[] due to NumberFormatInfo.CurrencySymbol returning a string
            //var currencies = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            //                            .Select(ci => ci.LCID).Distinct()
            //                            .Select(id => new RegionInfo(id))
            //                            .GroupBy(r => r.ISOCurrencySymbol)
            //                            .Select(g => g.First())
            //                            .Select(r => new GdCurrencyFiat
            //                            {
            //                                Code = r.ISOCurrencySymbol,
            //                                NameEnglish = r.CurrencyEnglishName,
            //                                NameNative = r.CurrencyNativeName,
            //                                DecimalCount = r.,
            //                                Symbol = r.CurrencySymbol,
            //                            });
            var currency = GdCurrencyFiatList.Get(GdCurrencyFiatCode.FromString(code));
            Assert.Contains(currency.Countries, x =>x.Code == expectedCountryCodeStr);
        }
    }
}
