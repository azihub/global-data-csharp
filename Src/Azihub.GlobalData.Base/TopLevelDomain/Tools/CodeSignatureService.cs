using Newtonsoft.Json;
using System.IO;
using static Azihub.GlobalData.Base.Settings;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public static class CodeSignatureService
    {
        private const string TldDataSignatureJson = "IanaOrgTlds.json";
        public static IanaOrgTlds GetIanaOrgTldsFromJson()
        {
            string signatureJson = File.ReadAllText($"{TldDataPath}{DS}{TldDataSignatureJson}");
            IanaOrgTlds tldAlphaByDomainHash = JsonConvert.DeserializeObject<IanaOrgTlds>(signatureJson);
            return tldAlphaByDomainHash;
        }

        public static void SaveIanaOrgTldsToJson(IanaOrgTlds ianaOrgTldsListHash)
        {
            string tldDataJson = JsonConvert.SerializeObject(ianaOrgTldsListHash, Formatting.Indented);
            File.WriteAllText($"{TldDataPath}{DS}{TldDataSignatureJson}", tldDataJson);
        }
    }
}
