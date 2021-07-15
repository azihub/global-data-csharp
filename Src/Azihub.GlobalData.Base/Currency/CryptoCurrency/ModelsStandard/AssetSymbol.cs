using System.Collections.Generic;
using Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard
{
    public partial class AssetSymbol
    {
        private AssetSymbol(string code)
        {
            Code = code;
        }

        public string Code { get; }

        public override string ToString()
        {
            return Code;
        }

        #region Dictionary
        private static Dictionary<string, AssetSymbol> Codes { get; set; } = GetAssetSymbolDict();
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

            if (Codes.Count == 0)
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
            if (Codes.TryGetValue(code, out AssetSymbol assetSymbol))
                return assetSymbol;

            throw new InvalidAssetSymbolException();
        }
    }
}