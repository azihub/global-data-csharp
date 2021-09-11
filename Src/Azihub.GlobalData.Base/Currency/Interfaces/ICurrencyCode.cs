using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.Currency.Interfaces
{
    public interface ICurrencyCode : IShortId
    {
        CurrencyType CurrencyType { get; }
    }

    public enum CurrencyType
    {
        Fiat,
        Crypto
    }
}
