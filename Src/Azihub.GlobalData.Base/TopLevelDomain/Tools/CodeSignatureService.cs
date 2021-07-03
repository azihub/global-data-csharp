using Newtonsoft.Json;
using System.IO;
using static Azihub.GlobalData.Base.Settings;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public static class CodeSignatureService
    {
        private const string TldDataSignatureJson = "tlds-alpha-by-domain.hash.json";
        public static TldAlphaByDomainHash GetSignatures()
        {
            string signatureJson = File.ReadAllText($"{TldDataPath}{DS}{TldDataSignatureJson}");
            TldAlphaByDomainHash tldAlphaByDomainHash = JsonConvert.DeserializeObject<TldAlphaByDomainHash>(signatureJson);
            return tldAlphaByDomainHash;
        }
    }
}
