using System.IO;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public static class Settings
    {
        public static char DS => Path.DirectorySeparatorChar;
        public static string TldDataPath => $"..{DS}..{DS}..{DS}..{DS}Azihub.GlobalData.Base{DS}TopLevelDomain{DS}";
        public static string TldConstsPath => $"{TldDataPath}TldConsts.cs";
        public static string TldDictPath => $"{TldDataPath}TldDict.cs";

        public static string TldDataSignatureJson = "IanaOrgTlds.json";
        public static string TldDataTxt = "tlds-alpha-by-domain.txt";
        public static string TldDictCs = "TldDict.cs";
        public static string TldConstsCs = "TldConsts.cs";
    }
}
