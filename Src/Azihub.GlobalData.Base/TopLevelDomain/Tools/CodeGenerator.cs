using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    /// <summary>
    /// C# Static Data Code Generator 
    /// </summary>
    public static class CodeGenerator
    {
        /// <summary>
        /// Generate a constant string to update static code data. 
        /// </summary>
        /// <param name="assetStrings"></param>
        /// <returns></returns>
        public static (string, string) GenCodes(IEnumerable<string> tlds)
        {
            StringBuilder tldConsts = new StringBuilder();
            tldConsts.Append(GetAssetSymbolsHeader());

            StringBuilder tldDict = new StringBuilder();
            tldDict.Append(GetAssetDictHeader());

            foreach (string tld in tlds)
            {
                tldConsts.Append(GetConstant(tld));
                tldDict.Append(GetDict(tld));
            }

            tldConsts.Append(GetConstFooter());
            tldDict.Append(GetAssetDictFooter());

            return (tldConsts.ToString(), tldDict.ToString());
        }

        /// <summary>
        /// Refer toAssetSymbols Sample
        /// </summary>
        /// <returns></returns>
        private static string GetAssetSymbolsHeader()
        {
            return @"namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public static class TldConsts
    {
";
        }

        private static string GetConstant(string name)
        {
            name = name.ToUpper();
            return "        /// <summary>\n" +
                   "        /// " + name + "\n" +
                   "        /// </summary>\n" +
                 $@"        public const string {name} = ""{name}"";" + "\n\n";
        }

        private static string GetConstFooter()
        {
            return @"
    }
}
";
        }

        /// <summary>
        /// Refer to <see cref="TldDictSample" />
        /// </summary>
        /// <returns></returns>
        private static string GetAssetDictHeader()
        {
            return @"using System;
using System.IO;
using System.Collections.Generic;

namespace TrustWallet.Asset.Data
{
    public static partial class Assets
    {
        /// <summary>
        /// Collection of assets
        /// </summary>
        public static IDictionary<string, IAsset> GetAssets()
        {
            var assets = new Dictionary<string, IAsset>();
            #region DictData";

        }


        private static string GetDict(string name)
        {
            StringBuilder assetDictItem = new StringBuilder();
            name = name.ToUpper();
            assetDictItem.Append($@"                {{ ""{name}"", new Tld(TldConsts.{name}) }}");
            
            return assetDictItem.ToString();

        }

        /// <summary>
        /// Footer for for AssetDict <see cref="TldDictSample" />
        /// </summary>
        /// <returns></returns>
        private static string GetAssetDictFooter()
        {
            return @"
            return tldDicts;
        }
    }
}
";
        }
    }
}
