using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public class TldDataUpdater
    {
        private readonly ILogger Logger;
        private IList<string> TldList { get; set; }
        public TldDataUpdater(ILogger<TldDataUpdater> logger)
        {
            Logger = logger;
        }
        public void Rebuild()
        {

            TldList = FetchTlds();

            (string tldConsts, string tldDict) = CodeGenerator.GenCodes(TldList);
            //_logger.LogDebug($"Parsed {blockchains.Count} blockchain");


            //(string assetSymbolsClass, string assetsDict) = CodeGenerator.GenAssetSymbols(assets.Values.ToList());

            TldAlphaByDomainHash signature = CodeSignatureService.GetSignatures();


            string tldConstsSha256 = tldConsts.GetSha256();
            string tldDictSha256 = tldDict.GetSha256();

            //if (assetSymbolSha256 != signature.AssetConstsCs)
            //{
            //    _logger.LogInformation("AssetSymbol needs to update");
            //    CodeSignatureService.SaveSignatures(new CodeSignatureService
            //    {
            //        AssetConstsCs = assetSymbolSha256,
            //        AssetsDictCs = assetsDictSha256
            //    });

            //    File.WriteAllText(AssetSymbolsPath, assetSymbolsClass);
            //}

            //if (assetsDictSha256 != signature.AssetsDictCs)
            //{
            //    _logger.LogInformation("AssetsDict needs to update");
            //    CodeSignatureService.SaveSignatures(new CodeSignatureService
            //    {
            //        AssetConstsCs = assetSymbolSha256,
            //        AssetsDictCs = assetsDictSha256
            //    });

            //    File.WriteAllText(AssetsDictPath, assetsDict);
            //}

            //AssetImages.Persist(ref assets);

            //var newClassNode = SyntaxFactory.ParseSyntaxTree(assetSymbolsClass).GetRoot()
            //                                .DescendantNodes()
            //                                .OfType<ClassDeclarationSyntax>()
            //                                .FirstOrDefault();
            ////// Retrieve the parent namespace declaration
            //var parentNamespace = (NamespaceDeclarationSyntax)newClassNode.Parent;
            //// Add the new class to the namespace
            //var newParentNamespace = parentNamespace.AddMembers(newClassNode).NormalizeWhitespace();




            //OutputHelper.WriteLine(blockchains.Select(x => x.Value).ToArray().ToString());
        }

        public static List<string> FetchTlds()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(IanaOrg.TLDS_ALPHA_BY_DOMAIN_URL).ConfigureAwait(true).GetAwaiter();
            string body = response.GetResult().Content.ReadAsStringAsync().ConfigureAwait(true).GetAwaiter().GetResult();
            List<string> list = Regex.Split(body, "\r\n|\r|\n").ToList();
            list.RemoveAll(x => x.ToUpper().Trim().StartsWith("#"));
            return list;
        }
    }
}
