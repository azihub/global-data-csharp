using System.Collections.Generic;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
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
                { BlockchainConsts.ETHEREUM , new Blockchain( BlockchainConsts.ETHEREUM, "Ethereum", 10) },
            #endregion
            };
            return blockchains;
        }
    }
}
