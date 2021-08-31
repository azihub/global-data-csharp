using Azihub.GlobalData.Base.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azihub.GlobalData.Base.Currency.Extensions
{
    public static class CurrencyLogo
    {
        public static string GetFlag(this CurrencyFiat currency)
        {
            var currencyCode = CountryList.GetAll().FirstOrDefault(x => x.Currency.Code == currency.Code);
            if (currencyCode == null)
            {
                return "";
                // throw new CurrencyCodeException(currency.Code);
            }
            return currency.Code != "EUR" ? currencyCode.CodeIso3.Code : "eun";
        }

    }
}
