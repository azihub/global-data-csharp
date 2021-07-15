using System.Collections.Generic;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    public partial class Blockchain
    {
        /// <summary>
        /// Collection of assets
        /// </summary>
        private static IDictionary<string, Blockchain> GetBlockchains()
        {
            Dictionary<string, Blockchain> blockchains = new Dictionary<string, Blockchain>()
            {
            #region Dictionary
                { BlockchainConsts.BITCOIN  , new Blockchain( BlockchainConsts.BITCOIN , "Bitcoin" , 10) },
                { BlockchainConsts.ETHEREUM , new Blockchain( BlockchainConsts.ETHEREUM, "Ethereum", 18 ) },
                { BlockchainConsts.TRON , new Blockchain( BlockchainConsts.TRON, "Tron", 6) },
            #endregion
            };
            return blockchains;
        }
    }
}
