using System.Collections.Generic;
using System.Linq;
using Azihub.GlobalData.Base.Authority;
using Azihub.GlobalData.Base.Country;
using Azihub.GlobalData.Base.Currency.Interfaces;

namespace Azihub.GlobalData.Base.Currency
{
    /// <summary>
    /// Based on ISO 4217
    /// <see href="https://www.iso.org/iso-4217-currency-codes.html">ISO official page</see>
    /// Source 1: <see href="https://www.six-group.com/dam/download/financial-information/data-center/iso-currrency/amendments/lists/list_one.xml">Source XML</see>
    /// Source 2: <see href="https://www.six-group.com/dam/download/financial-information/data-center/iso-currrency/amendments/lists/list_three.xml">Source XML</see>
    /// <see href="https://en.wikipedia.org/wiki/ISO_4217">Wikipedia</see>
    /// </summary>
    public class CurrencyFiat : ICurrency
    {
        public ushort Id { get; }

        /// <summary>
        /// Fullname
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Shortname
        /// </summary>
        public string NameShort { get; set; }

        /// <summary>
        /// ISO-4217 code in three letter.
        /// <see href="https://www.iso.org/iso-4217-currency-codes.html">ISO official page</see>
        /// Source 1: <see href="https://www.six-group.com/dam/download/financial-information/data-center/iso-currrency/amendments/lists/list_one.xml">Source XML</see>
        /// Source 2: <see href="https://www.six-group.com/dam/download/financial-information/data-center/iso-currrency/amendments/lists/list_three.xml">Source XML</see>
        /// <see href="https://en.wikipedia.org/wiki/ISO_4217">Wikipedia</see>
        /// </summary>
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

        /// <summary>
        /// Single character Symbol of currency 
        /// Example $, €, ¥
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// The subunit in Latin (ASCII)
        /// </summary>
        public string SubunitLatin { get; set; }
        /// <summary>
        /// The subunit in native language (Unicode)
        /// </summary>
        public string SubunitNative { get; set; }

        /// <summary>
        /// Fraction of currency, some has zero, usually two two and rarely three
        /// </summary>
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
