using Azihub.Utilities.Base.Extensions.String;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public class TldDataUpdater
    {
        private readonly ILogger Logger;
        private IanaOrgTlds IanaOrgTlds { get; set; }
        public TldDataUpdater(ILogger<TldDataUpdater> logger)
        {
            Logger = logger;
        }
        public void Rebuild()
        {

            IanaOrgTlds = FetchTlds();

            //_logger.LogDebug($"Parsed {blockchains.Count} blockchain");


            //(string assetSymbolsClass, string assetsDict) = CodeGenerator.GenAssetSymbols(assets.Values.ToList());

            IanaOrgTlds ianaOrgTldsJson = CodeSignatureService.GetIanaTldsFromJson();

            if (IanaOrgTlds.Hash != ianaOrgTldsJson.Hash)
            {
                Logger.LogInformation("Tld List needs to update.");
                (string tldConsts, string tldDict) = CodeGenerator.GenCodes(IanaOrgTlds);
                CodeSignatureService.SaveSignatures(IanaOrgTlds);

                File.WriteAllText(tldConsts, tldConsts);
                File.WriteAllText(tldDict, tldDict);
            }

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

        public static IanaOrgTlds FetchTlds()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(IanaOrgTlds.TLDS_ALPHA_BY_DOMAIN_URL).ConfigureAwait(true).GetAwaiter();
            string body = response.GetResult().Content.ReadAsStringAsync().ConfigureAwait(true).GetAwaiter().GetResult();
            List<string> list = Regex.Split(body, "\r\n|\r|\n").ToList();
            list.RemoveAll(x => x.ToUpper().Trim().StartsWith("#"));
            return new IanaOrgTlds(body, list);
        }
    }
}
