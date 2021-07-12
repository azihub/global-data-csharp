using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static System.Environment;
using System.Linq;
using System.Text;
using Azihub.Utilities.Base.Extensions.String;

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
        public static (string, string) GenCodes(IanaOrgTlds ianaOrgTlds)
        {
            StringBuilder tldConsts = new StringBuilder();
            tldConsts.Append(GetAssetSymbolsHeader());

            StringBuilder tldDict = new StringBuilder();
            tldDict.Append(GetDictHeader());

            foreach (string tld in ianaOrgTlds.List)
            {
                tldConsts.Append(GetConstant(tld.ToConstantCase()));
                tldDict.Append(GetDict(tld));
            }

            tldConsts.Append(GetConstFooter());
            tldDict.Append(GetDictFooter());

            #region 
            var newClassNode = SyntaxFactory.ParseSyntaxTree(tldConsts.ToString()).GetRoot()
                                            .DescendantNodes()
                                            .OfType<ClassDeclarationSyntax>()
                                            .FirstOrDefault();
            // Retrieve the parent namespace declaration
            var parentNamespace = (NamespaceDeclarationSyntax) newClassNode.Parent;
            // Add the new class to the namespace
            parentNamespace.AddMembers(newClassNode).NormalizeWhitespace();
            #endregion

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
        private static string GetDictHeader()
        {
            return @"using System.Collections.Generic;
using System.Linq;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public partial class Tld
    {
        public static IList<Tld> TldsList => TldsDict.Values.ToList();

        private static readonly Dictionary<string, Tld> TldsDict = new Dictionary<string, Tld>()
        {
";

        }


        private static string GetDict(string name)
        {
            StringBuilder assetDictItem = new StringBuilder();
            name = name.ToUpper();
            assetDictItem.Append($@"                {{ TldConsts.{name}, new Tld(TldConsts.{name}) }},{NewLine}");
            
            return assetDictItem.ToString();

        }

        /// <summary>
        /// Footer for for AssetDict <see cref="TldDictSample" />
        /// </summary>
        /// <returns></returns>
        private static string GetDictFooter()
        {
            return @"
        };
    }
}
";
        }
    }
}
