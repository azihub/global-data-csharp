namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public class AssetSymbolFactory
    {
        public static AssetSymbol BtcBitcoin => AssetSymbol.FromString(AssetSymbolConsts.BTC_BITCOIN);
        public static AssetSymbol EthEthereum => AssetSymbol.FromString(AssetSymbolConsts.ETH_ETHEREUM);
        public static AssetSymbol TrxTron => AssetSymbol.FromString(AssetSymbolConsts.TRX_TRON);
        public static AssetSymbol UsdtTether => AssetSymbol.FromString(AssetSymbolConsts.USDT_TETHER);
    }
}