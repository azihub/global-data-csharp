// <Header>

using System;
using System.Collections.Generic;
using System.IO;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.AssetProperties;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    public partial class Assets
    {
        /// <summary>
        /// Collection of assets
        /// </summary>
        public static Dictionary<string, IAsset> GetAssets()
        {
            Dictionary<string, IAsset> assets = new Dictionary<string, IAsset>()
            {
// </Header>
// <Body>
                {
                    AssetSymbolConsts.BTC_BITCOIN,
                    new Coin
                    {
                        Name = @"Aave Token",
                        Code = "AAVE",
                        Symbol = AssetSymbolFactory.BtcBitcoin,
                        Website = new Uri("https://www.bitcoin.org"),
                        Description = @"Aave is a decentralized finance protocol that allows people to lend and borrow crypto.",
                        ShortDescription = "",
                        Explorer = new Uri("https://explorer.binance.org/asset/AAVE-8FA"),
                        Research = new Uri("https://research.binance.com/en/projects/aave-protocol"),
                        Decimals = 8,
                        Status = AssetStatus.Active,
                        LogoPng = File.ReadAllBytes(AssetSymbolConsts.BTC_BITCOIN + ".png"),
                        Links = new Link[] {  new Link() },
                        Tags = Array.Empty<string>()
                    }
                }
// </Body>
// <Footer>
            };
            return assets;
        }
    }
}
// </Footer>