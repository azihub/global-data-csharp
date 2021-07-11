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
            CodeSignatureService.SaveIanaOrgTldsToJson(IanaOrgTlds);
            (string tldConsts, string tldDict) = CodeGenerator.GenCodes(IanaOrgTlds);
            File.WriteAllText(Settings.TldConstsPath, tldConsts);
            File.WriteAllText(Settings.TldDictPath, tldDict);
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
