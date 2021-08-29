# Global Data

- Countries
- Currencies (Fiat and Cyrpto)
- Banks


## Countries: `Azihub.GlobalData.Base.Country`
.NET built-in Country data also has many missing information such as an ENUM of strings to
get `ISO 3166-2` or `ISO 3166-3`

Usage
```C#
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
```

## Currencies: `Azihub.GlobalData.Base.Currency`
This project aim to solve the missing data within .NET existing globalization, for example,
number of decimal in currency is missing, or another example, the block of currency used for
displaying 100 YEN of Japan.

Also list of Cryptocurrencies combined with Fiat currencies:
- `ICurrency.cs`
- `CurrencyCrypto.cs`
- `CurrencyFiat.cs`

Validation: 
```C#
string countryCodeIso2 = "ZZ";
Assert.Throws<InvalidCountryCodeException>(() => GdCountryIso2Code.FromString( countryCodeIso2 ));

string countryCodeIso2 = "ZZZ";
Assert.Throws<InvalidCountryCodeException>(() => GdCountryIso2Code.FromString( countryCodeIso3 ));

```
Other usages:
```C#
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
```

## Top Level Domains: `Azihub.GlobalData.Base.TopLevelDomain`
The purpose of the list is to validate domain name, this is very useful
to validate if the email or domain is a valid domain by Iana's standard.

Usages:
```C#
[Theory]
[InlineData("COM")]
[InlineData("net")]
[InlineData("org")]
[InlineData("gov")]
public void ValidateTldTest(string tldStr)
{
    Tld tld = Tld.FromString(tldStr);
    Output.WriteLine($"Expected: {tldStr}, Output: {tld.Value}");
    Assert.Equal(tldStr.ToLower(), tld.Value);
}

[Fact]
public void InvalidTldTest()
{
    Assert.Throws<InvalidTopLevelDomainException>(
        () => Tld.FromString("DOESNOTEXISTS")
        );
}
```


## Networking: MediaTypes

.NET is missing a Type of [MediaTypes](https://en.wikipedia.org/wiki/Media_type "Wikipedia article")
This section is a work in progress of implementation based on Iana standard.

Usage:
```C#
[Theory]
[InlineData("application/json","json")]
[InlineData("text/plain","txt")]
public void TestGetMediaTypeFromString(string code, string expectedExtension)
{
    MediaType mediaType = MediaType.FromString(code);

    Output.WriteLine($"MediaType {code} has extension:" + mediaType.Extensions.First(x => x.Contains(expectedExtension)));
    Assert.Equal(expectedExtension, mediaType.Extensions.First(x => x.Contains(expectedExtension)));
}
```