using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Country.Exceptions;
using Azihub.GlobalData.Base.Tests.Abstract;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests
{
    public class GdCountryTests : TestBase
    {
        public GdCountryTests(ITestOutputHelper output) : base(output) { }

        #region Iso2
        [Theory]
        [InlineData(Iso2Codes.AF)]
        [InlineData(Iso2Codes.IR)]
        [InlineData(Iso2Codes.MY)]
        [InlineData("us")]
        public void ParseCountryIso2CodeTest(string code)
        {
            CountryIso2Code countryCode = CountryIso2Code.FromString( code );
            Output.WriteLine($"Expected: {code.ToUpper()} , output: {countryCode.Code}");
            Assert.Equal(code.ToUpper(), countryCode.Code);
        }

        [Theory]
        [InlineData(Iso2Codes.AF, Iso2Codes.Afghanistan)]
        [InlineData(Iso2Codes.IR, Iso2Codes.Iran)]
        [InlineData(Iso2Codes.MY, Iso2Codes.Malaysia)]
        [InlineData(Iso2Codes.US, Iso2Codes.United_States)]
        public void Iso2FullNameCodeTest(string code, string fullnameCode)
        {
            Assert.Equal(code, fullnameCode);
        }

        [Fact]
        public void ParseCountryIso2CodeFailTest()
        {
            Assert.Throws<InvalidCountryCodeException>( () => CountryIso2Code.FromString("ZZ") );
        }
        #endregion

        #region Iso3
        [Theory]
        [InlineData(Iso3Codes.AFG)]
        [InlineData(Iso3Codes.IRN)]
        [InlineData(Iso3Codes.MYS)]
        [InlineData("usA")]
        public void ParseCountryIso3CodeTest(string code)
        {
            GdCountryIso3Code countryCode = GdCountryIso3Code.FromString(code);
            Assert.Equal(code.ToUpper(), countryCode.Code);
        }

        [Fact]
        public void ParseCountryIso3CodeFailTest()
        {
            Assert.Throws<InvalidCountryCodeException>(() => GdCountryIso3Code.FromString("ZZ"));
        }
        #endregion

        [Theory]
        [InlineData(Iso2Codes.AF, 93, "AFN")]
        [InlineData(Iso2Codes.IR, 98, "IRR")]
        [InlineData(Iso2Codes.MY, 60, "MYR")]
        [InlineData(Iso2Codes.US, 1, "USD")]
        public void GetGdCountry(string code, uint callingCode, string expectedCurrency)
        {
            var country = CountryList.Get( CountryIso2Code.FromString(code) );
            Output.WriteLine($"Expected currency: {expectedCurrency}, output: {country.Currency.Code}");
            Assert.Equal(callingCode, country.CallingCode);
            Assert.Equal(expectedCurrency, country.Currency.Code);
        }
    }
}
