using System;
using System.Collections.Generic;
using Version = Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.TokenListProperties.Version;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.CoinProperties
{
    public class TokenList
    {
        public string Name { get; set; }
        public Uri LogoUri { get; set; }
        public DateTime TimeStamp { get; set; }
        public IList<Token> Tokens { get; set; }
        public Version Version { get; set; }
    }
}
