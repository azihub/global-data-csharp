using Newtonsoft.Json;
using System.IO;
using static Azihub.GlobalData.Base.Settings;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public static class CodeSignatureService
    {
        private const string TldDataSignatureJson = "IanaOrgTlds.json";
        private const string TldDictCs = "TldDict.cs";
        private const string TldConstsCs = "TldConsts.cs";
        public static IanaOrgTlds GetIanaOrgTldsFromJson()
        {
            string signatureJson = (string) File.ReadAllText($"{TldDataPath}{DS}{TldDataSignatureJson}");
            IanaOrgTlds tldAlphaByDomainHash = JsonConvert.DeserializeObject<IanaOrgTlds>(signatureJson, new IanaOrgTldsConverter());
            return tldAlphaByDomainHash;
        }

        public static void SaveIanaOrgTldsToJson(IanaOrgTlds ianaOrgTldsListHash)
        {
            string tldDataJson = JsonConvert.SerializeObject(ianaOrgTldsListHash, Formatting.Indented);
            File.WriteAllText($"{TldDataPath}{DS}{TldDataSignatureJson}", tldDataJson);
        }

        public static void SaveIanaOrgTldsToCs(string consts, string dict)
        {
            File.WriteAllText($"{TldDataPath}{DS}{TldConstsCs}", consts);
            File.WriteAllText($"{TldDataPath}{DS}{TldDictCs}", dict);
        }
    }
}
