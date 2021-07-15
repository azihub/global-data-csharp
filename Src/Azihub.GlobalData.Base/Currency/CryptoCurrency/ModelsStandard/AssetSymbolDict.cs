// <Header>

using System.Collections.Generic;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public partial class AssetSymbol
    {

        private static Dictionary<string, AssetSymbol> GetAssetSymbolDict()
        {
            Dictionary<string, AssetSymbol> assets = new Dictionary<string, AssetSymbol>()
            {
                #region Dictionary

// </Header>
// <Body>
                { AssetSymbolConsts.BTC_BITCOIN, new AssetSymbol(AssetSymbolConsts.BTC_BITCOIN)},
                { AssetSymbolConsts.ETH_ETHEREUM, new AssetSymbol(AssetSymbolConsts.ETH_ETHEREUM)},
                { AssetSymbolConsts.TRX_TRON, new AssetSymbol(AssetSymbolConsts.TRX_TRON)},
                { AssetSymbolConsts.USDT_TETHER, new AssetSymbol(AssetSymbolConsts.USDT_TETHER)}
// </Body>
// <Footer>
                #endregion
            };
            return assets;
        }
    }
}
// </Footer>