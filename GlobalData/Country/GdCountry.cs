
using GlobalData.Currency;

namespace GlobalData.Country
{
    public class GdCountry
    {
        public GdCountry(string name, string namePrefix, string namePostfix, string codeIso2, string codeIso3, string currencyCode, uint callingCode, uint[] callingCodes)
        {
            Name = name;
            NameAllCaps = name.ToUpper();
            NamePrefix = namePrefix;
            NamePostfix = namePostfix;
            CodeIso2 = GdCountryIso2Code.FromString(codeIso2);
            CodeIso3 = GdCountryIso3Code.FromString(codeIso3);
            Currency = GdCurrencyFiatCode.FromString(currencyCode);
            CallingCode = callingCode;
            CallingCodes = callingCodes;
        }
        public string Name { get; }
        public string NameAllCaps { get; }
        public string NamePrefix { get; }
        public string NamePostfix { get; }
        
        /// <summary>
        /// ISO 3166-1 alpha-2
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2
        /// </summary>
        public GdCountryIso2Code CodeIso2 { get; }

        /// <summary>
        /// ISO 3166-1 alpha-3
        /// https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3
        /// </summary>
        public GdCountryIso3Code CodeIso3 { get; }

        /// <summary>
        /// Based on ISO 4217 : https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        public GdCurrencyFiatCode Currency { get; }

        /// <summary>
        /// Primary country code https://en.wikipedia.org/wiki/List_of_country_calling_codes
        /// </summary>
        public uint CallingCode { get; }

        public uint[] CallingCodes { get; }

    }
}
