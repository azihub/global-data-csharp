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
        public void GdCurrencyUShortValueTest()
        {
            GD<FiatCurrency> usDollar = new GD<FiatCurrency>.FromString("USD");
            JsonConvert
            Assert.Equal(1, usDollar.Id);
            Assert.Equal("USD", usDollar.Code.Value);
            Assert.Equal("US Dollar", usDollar.Data.Name);
        }

        #region LegacyCurrency
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
        #endregion
    }

    public class FiatCurrency : IGData<FiatCurrency>
    {
        private FiatCurrency(string code)
        {
            Code = code;
        }

        public string Code { get; }

        public FiatCurrency Data { get; }
        FiatCurrency IGData<FiatCurrency>.FromString(string code)
        {
            return FromString(code);
        }

        public static FiatCurrency FromString(string code)
        {
            return new(code);
        }
    }

    public class ByteArray<T> where T : IGData<T>
    {
        public byte ByteCount { get; }
    }

    public class GD<T> where T : IGData<T>
    {
        public byte[] Id { get; }
        public string Code
        {
            get
            {
                return Data.Code;
            }
        }

        public IGData<T> Data { get; }

        public class FromString : GD<T>
        {
            public FromString(string usd)
            {
                return new()
            }
        }
    }
}
