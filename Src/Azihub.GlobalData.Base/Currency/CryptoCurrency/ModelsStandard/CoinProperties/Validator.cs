using System;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.CoinProperties.ValidatorProperties;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.CoinProperties
{
    public class Validator
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Website { get; set; }
        public Payout Payout { get; set; }
        public Staking Staking { get; set; }
        public Status Status { get; set; }
        public byte[] LogoPng { get; set; }
    }
}
