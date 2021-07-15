using System;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public class Link : ILink
    {
        public LinkType Name { get; set; }
        public Uri Url { get; set; }
    }

    public enum LinkType
    {
        Twitter,
        Telegram,
        Facebook,
        Discord,
        Github,
        WhitePaper,
        Reddit
    }
}
