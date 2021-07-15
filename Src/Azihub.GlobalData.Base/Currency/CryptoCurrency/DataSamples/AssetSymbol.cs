using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.DataSamples
{
    /// <summary>
    /// Controller Enum with [Code=>string] system
    /// </summary>
    public partial class AssetSymbol : IAssetSymbol
    {
        private AssetSymbol(string symbol)
        {
            Code = symbol;
        }

        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        #region Dictionary
        private static Dictionary<string, AssetSymbol> AssetSymbolDict => GetAssetSymbolDict();
        #endregion

        /// <summary>
        /// Create AssetSymbol from string value (case insensitive)
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static AssetSymbol FromString(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new InvalidAssetSymbolException();

            if (AssetSymbolDict.Count == 0)
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

            code = code.Trim().ToUpper();
            if (AssetSymbolDict.TryGetValue(code, out AssetSymbol assetSymbol))
                return assetSymbol;

            throw new InvalidAssetSymbolException();
        }

    }
}