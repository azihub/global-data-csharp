namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    public partial class BlockchainFactory
    {
        public static Blockchain Bitcoin => Blockchain.FromString(BlockchainConsts.BITCOIN);
        public static Blockchain Ethereum => Blockchain.FromString(BlockchainConsts.ETHEREUM);
        public static Blockchain Tron => Blockchain.FromString(BlockchainConsts.TRON);
    }
}
