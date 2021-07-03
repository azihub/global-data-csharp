using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Currency;
using Azihub.GlobalData.Base.Currency.Exceptions;
using Azihub.GlobalData.Base.Tests.Abstract;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests
{
    public class GdCurrencyTests : TestBase
    {
        public GdCurrencyTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void CurrencyCodeValidationTest()
        {
            Assert.Throws<InvalidCurrencyCodeException>(() => CurrencyFiatCode.FromString("ZZZ"));
        }

        [Theory]
        [InlineData(Iso3FiatCodes.USD, Iso2Codes.US)]
        [InlineData(Iso3FiatCodes.EUR, Iso2Codes.Netherlands_The)]
        [InlineData(Iso3FiatCodes.IRR, Iso2Codes.Iran)]
        [InlineData(Iso3FiatCodes.MYR, Iso2Codes.Malaysia)]
        public void GetGdCurrencyFiat(string code, string expectedCountryCodeStr)
        {
            var currency = CurrencyFiatList.Get(CurrencyFiatCode.FromString(code));
            Output.WriteLine($"code: {code}, Received: {currency.Code} is expecting: {expectedCountryCodeStr}");
            Assert.Contains(currency.Countries, x =>x.Code == expectedCountryCodeStr);
        }
    }
}
