using Newtonsoft.Json;
using System.IO;
using static Azihub.GlobalData.Base.Settings;

namespace Azihub.GlobalData.Base.TopLevelDomain.Tools
{
    public static class CodeSignatureService
    {
        public static IanaOrgTlds GetIanaOrgTldsFromJson()
        {
            string signatureJson = File.ReadAllText($"{TldDataPath}{DS}{TldDataSignatureJson}");
            IanaOrgTlds tldAlphaByDomainHash = JsonConvert.DeserializeObject<IanaOrgTlds>(signatureJson, new IanaOrgTldsConverter());

            tldAlphaByDomainHash.Bytes = File.ReadAllBytes($"{TldDataPath}{DS}{TldDataTxt}");
            return tldAlphaByDomainHash;
        }

        public static void SaveIanaOrgTldsToJson(IanaOrgTlds ianaOrgTlds, bool persist = true)
        {
            string tldDataJson = JsonConvert.SerializeObject(ianaOrgTlds, Formatting.Indented);
            if (persist)
            {
                File.WriteAllBytes($"{TldDataPath}{DS}{TldDataTxt}", ianaOrgTlds.Bytes);
                File.WriteAllText($"{TldDataPath}{DS}{TldDataSignatureJson}", tldDataJson);
            }
        }



        public static void SaveIanaOrgTldsToCs(string consts, string dict)
        {
            File.WriteAllText($"{TldDataPath}{DS}{TldConstsCs}", consts);
            File.WriteAllText($"{TldDataPath}{DS}{TldDictCs}", dict);
        }
    }
}
