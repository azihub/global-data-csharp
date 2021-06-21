using System.Collections.Generic;
using System.Linq;
using GlobalData.Base.Authority;
using GlobalData.Base.Country;
using GlobalData.Base.Currency.Interfaces;

namespace GlobalData.Base.Currency
{
    /// <summary>
    /// Based on ISO 4217 : https://en.wikipedia.org/wiki/ISO_4217
    /// </summary>
    public class GdCurrencyFiat : ICurrency
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
                return GdCountryList.GetAll().First(x => x.Currency.Code == Code).CodeIso2.Code.ToUpper();
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
        public IAuthority IssuingAuthority { get; set; }

        /// <summary>
        /// List of countries using the currency.
        /// </summary>
        public IList<GdCountryIso2Code> Countries { get; set; }
    }
}
