using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    public partial class Assets
    {
        #region Dictionary
        private static Dictionary<string, IAsset> AssetsDict => GetAssets();
        #endregion

        /// <summary>
        /// Create AssetSymbol from string value (case insensitive)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IAsset FromSymbol(IAssetSymbol asset)
        {

            if (AssetsDict.Count == 0)
            {
                //var assets = Assets.GetAssets();
                //foreach (var keyValue in assets)
                //{
                //    Codes.Add(
                //        keyValue.Key,
                //        new AssetSymbol(keyValue.Key)
                //        );
                //}
            }

            if (AssetsDict.TryGetValue(asset.Code, out IAsset assetInstance))
                return assetInstance;

            throw new AssetWasNotFoundException(asset.Code);
        }
    }
}
