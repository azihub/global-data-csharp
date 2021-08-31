using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Currency;
using Azihub.GlobalData.Base.Currency.Exceptions;
using Azihub.GlobalData.Base.Currency.Extensions;
using Azihub.Utilities.Base.Tests;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.Country
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
            CurrencyFiat currency = CurrencyFiatList.Get(CurrencyFiatCode.FromString(code));
            Output.WriteLine($"code: {code}, Received: {currency.Code} is expecting: {expectedCountryCodeStr}");
            Assert.Contains(currency.Countries, x =>x.Code == expectedCountryCodeStr);
        }

        [Fact]
        public void GetCurrencyFiatTest()
        {
            var euro = CurrencyFiatCodeFactory.Euro_EUR;

            Assert.Equal("Euro", euro.GetCurrencyFiat().Name);
        }

        [Fact]
        public void GetAllFlags()
        {
            List<CurrencyFiat> currencyFiats = CurrencyFiatList.GetList();
            foreach(CurrencyFiat currency in currencyFiats)
            {
                string flag = currency.GetFlag();
                Output.WriteLine($"Flag for {currency.Code} currency is {flag}");
                Assert.False(string.IsNullOrEmpty(flag));
            }
        }
    }
}
