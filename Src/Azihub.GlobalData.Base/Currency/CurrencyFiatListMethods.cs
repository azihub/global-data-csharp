using Azihub.GlobalData.Base.Currency.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Azihub.GlobalData.Base.Currency
{
    public static partial class CurrencyFiatList
    {

        /// <summary>
        /// Get a GdCountry by Iso2 Code.
        /// </summary>
        /// <param name="gdCountryCode"></param>
        /// <returns>Instance of GdCountry</returns>
        public static CurrencyFiat Get(CurrencyFiatCode gdCountryCode)
        {
            if (GdCurrencyFiatListDict.TryGetValue(gdCountryCode.Code, out CurrencyFiat value))
                return value;

            throw new InvalidCurrencyCodeException(gdCountryCode.Code);
        }

        public static CurrencyFiat[] GetAll()
        {
            return GdCurrencyFiatListDict.Values.ToArray();
        }

        public static List<CurrencyFiat> GetList()
        {
            return GdCurrencyFiatListDict.Values.ToList();
        }
    }
}
