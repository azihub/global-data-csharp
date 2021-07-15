namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public partial class Blockchain
    {
        public static Blockchain Bitcoin => new Blockchain(BlockchainConsts.BITCOIN);
        public static Blockchain Ethereum => new Blockchain(BlockchainConsts.ETHEREUM);
        public static Blockchain Tron => new Blockchain(BlockchainConsts.TRON);
    }
}
