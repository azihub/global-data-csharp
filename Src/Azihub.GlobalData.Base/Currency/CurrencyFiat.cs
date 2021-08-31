using System.Collections.Generic;
using System.Linq;
using Azihub.GlobalData.Base.Authority;
using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Currency.Interfaces;

namespace Azihub.GlobalData.Base.Currency
{
    /// <summary>
    /// Based on ISO 4217 : https://en.wikipedia.org/wiki/ISO_4217
    /// </summary>
    public class CurrencyFiat : ICurrency
    {
        /// <summary>
        /// Fullname
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Shortname
        /// </summary>
        public string NameShort { get; set; }
        public string Code { get; set; }
        public string FlagCodeIso2 {
            get
            {
                // ReSharper disable once ConvertIfStatementToReturnStatement
                if (Code == "EUR")
                    return "EU";
                return CountryList.GetAll().First(x => x.Currency.Code == Code).CodeIso2.Code.ToUpper();
            }
        }
        public string Symbol { get; set; }
        public string SubunitLatin { get; set; }
        public string SubunitNative { get; set; }
        public byte DecimalCount { get; set; }
        
        /// <summary>
        /// Minimum Block to display for currency with high quantity like Indonesian Rupee or Japan's Yen
        /// </summary>
        public uint ExchangeBlock { get; set; }

        /// <summary>
        /// Country/Territory/Union that issued the currency.
        /// </summary>
        public IAuthorityCodeIso2 IssuingAuthority { get; set; }

        /// <summary>
        /// List of countries using the currency.
        /// </summary>
        public IList<CountryIso2Code> Countries { get; set; }

        /// <summary>
        /// Get a GdCountry by Iso2 Code.
        /// </summary>
        /// <param name="gdCountryCode"></param>
        /// <returns>Instance of GdCountry</returns>
        public static CurrencyFiat Get(CurrencyFiatCode gdCountryCode)
        {
            return CurrencyFiatList.Get(gdCountryCode);
        }

        public static CurrencyFiat[] GetAll()
        {
            return CurrencyFiatList.GetAll();
        }
    }
}
