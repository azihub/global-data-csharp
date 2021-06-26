using Azihub.GlobalData.Base.Currency;

namespace Azihub.GlobalData.Base.Country.Interfaces
{
    public interface ICountry
    {
        uint CallingCode { get; }
        uint[] CallingCodes { get; }
        CountryIso2Code CodeIso2 { get; }
        GdCountryIso3Code CodeIso3 { get; }
        CurrencyFiatCode Currency { get; }
        string Name { get; }
        string NameAllCaps { get; }
        string NamePostfix { get; }
        string NamePrefix { get; }
    }
}