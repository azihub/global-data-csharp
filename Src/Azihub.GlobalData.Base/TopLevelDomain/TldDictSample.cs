using System.Collections.Generic;
using TldConsts = Azihub.GlobalData.Base.TopLevelDomain.TldConstsSample;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public class TldDictSample
    {
        public static IDictionary <string, Tld> GetTlds()
        {
            Dictionary<string, Tld> tldDict = new Dictionary<string, Tld>()
            {
                { "com", new Tld(TldConsts.COM) }
            };
            return tldDict;
        }
    }
}
