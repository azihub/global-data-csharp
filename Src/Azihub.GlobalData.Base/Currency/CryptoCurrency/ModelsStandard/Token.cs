using System;
using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.AssetProperties;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.TokenProperties;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public class Token : IAsset
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IAssetSymbol Symbol { get; set; }
        public byte Decimals { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Uri Website { get; set; }
        public Uri SourceCode { get; set; }
        public Uri WhitePaper { get; set; }
        public Uri Explorer { get; set; }
        public Uri Research { get; set; }
        public Uri AuditReport { get; set; }
        public Uri DataSource { get; set; }
        public Link[] Links { get; set; } = Array.Empty<Link>();
        public AssetStatus Status { get; set; }
        public AssetType AssetType { get; set; } = AssetType.Token;
        public string[] Tags { get; set; } = Array.Empty<string>();
        public byte[] LogoPng { get; set; }
        public IList<TokenListing> TokenListings { get; set; }
    }
}
