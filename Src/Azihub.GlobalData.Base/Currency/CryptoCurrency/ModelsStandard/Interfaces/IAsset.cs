using System;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.AssetProperties;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces
{
    /// <summary>
    /// GlobalData's definition of a Cryptocurrency asset (Token, NativeToken, NFT, Smart Contracts)
    /// </summary>
    public interface IAsset
    {
        string Name { get; set; }
        IAssetSymbol Symbol { get; set; }
        byte Decimals { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }
        Uri Website { get; set; }
        Uri Explorer { get; set; }
        Uri Research { get; set; }
        Uri AuditReport { get; set; }
        Uri DataSource { get; set; }
        AssetType AssetType { get; set; }
        Link[] Links { get; set; }
        AssetStatus Status { get; set; }
        string[] Tags { get; set; }
        byte[] LogoPng { get; set; }
    }
}
