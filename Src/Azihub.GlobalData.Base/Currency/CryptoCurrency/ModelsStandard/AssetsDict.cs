using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public static partial class Assets
    {
        /// <summary>
        /// Collection of assets
        /// </summary>
        public static IDictionary<string, IAsset> GetAssets()
        {
            var assets = new Dictionary<string, IAsset>();
            #region DictData
            #endregion
            return assets;
        }
    }
}
