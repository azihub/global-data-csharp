using System;
using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.AssetProperties;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.CoinProperties;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    /// <summary>
    /// Coin is digital asset stored as native blockchain token
    /// </summary>
    public class Coin : IAsset
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public IAssetSymbol Symbol { get; set; }
        public string SymbolConst { get; set; }
        public byte Decimals { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Uri Website { get; set; }
        public Uri Research { get; set; }
        public Uri Explorer { get; set; }
        public Uri AuditReport { get; set; }
        public Uri DataSource { get; set; }
        public AssetType AssetType { get; set; } = AssetType.Coin;
        public Link[] Links { get; set; } = Array.Empty<Link>();
        public string[] Tags { get; set; } = Array.Empty<string>();
        public AssetStatus Status { get; set; }
        /// <summary>
        /// List of Validators (Applies to POS coins only)
        /// </summary>
        public IList<Validator> Validators { get; set; }
        public byte[] LogoPng { get; set; }
        public IList<Token> TokenAsset { get; set; }
    }
}
