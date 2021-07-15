using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.TokenProperties
{
    public class TokenListing : ITokenListing
    {
        public IBlockchain Blockchain { get; set; }
        public string Id { get; set; }
        public string TokenType { get; set; }
        public byte Decimals { get; set; }
    }
}