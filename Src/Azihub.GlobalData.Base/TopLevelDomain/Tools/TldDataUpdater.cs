using Azihub.Utilities.Base.Extensions.String;
using static Azihub.GlobalData.Base.TopLevelDomain.Settings;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
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
            Logger.LogInformation($"Fetched IanaOrgTlds with {IanaOrgTlds.Count} records");
            CodeSignatureService.SaveIanaOrgTldsToJson(IanaOrgTlds);
            (string tldConsts, string tldDict) = CodeGenerator.GenCodes(IanaOrgTlds);
            File.WriteAllText(Settings.TldConstsPath, tldConsts);
            File.WriteAllText(Settings.TldDictPath, tldDict);
        }

        /// <summary>
        /// Return object of IanaOrgTlds and set of byte array to keep original data.
        /// </summary>
        /// <returns></returns>
        public static IanaOrgTlds FetchTlds()
        {
            HttpClient httpClient = new HttpClient();
            ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter response = httpClient.GetAsync(IanaOrgTlds.TLDS_ALPHA_BY_DOMAIN_URL).ConfigureAwait(true).GetAwaiter();
            string body = response.GetResult().Content.ReadAsStringAsync().ConfigureAwait(true).GetAwaiter().GetResult();
            byte[] bytes = response.GetResult().Content.ReadAsByteArrayAsync().ConfigureAwait(true).GetAwaiter().GetResult();

            List<string> list = Regex.Split(body, "\r\n|\r|\n").ToList();
            list.RemoveAll(x => x.ToUpper().Trim().StartsWith("#"));
            return new IanaOrgTlds(body, list, bytes);
        }
    }
}
