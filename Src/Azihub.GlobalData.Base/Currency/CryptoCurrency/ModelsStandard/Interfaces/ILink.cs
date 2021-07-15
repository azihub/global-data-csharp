using System;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces
{
    public interface ILink
    {
        LinkType Name { get; set; }
        Uri Url { get; set; }
    }
}
