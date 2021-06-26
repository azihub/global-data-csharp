using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Currency;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests
{
    public class GdCurrencyTests
    {
        private readonly ITestOutputHelper _output;
        public GdCurrencyTests(ITestOutputHelper output)
        {
            _output = output;

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
            var currency = GdCurrencyFiatList.Get(CurrencyFiatCode.FromString(code));
            _output.WriteLine($"code: {code}, Received: {currency.Code} is expecting: {expectedCountryCodeStr}");
            Assert.Contains(currency.Countries, x =>x.Code == expectedCountryCodeStr);
        }
    }
}
