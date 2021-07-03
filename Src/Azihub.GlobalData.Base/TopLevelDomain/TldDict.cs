using System.Collections.Generic;
using System.Linq;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public partial class Tld
    {
        public static IList<Tld> TldsList => TldsDict.Values.ToList();

        private static readonly Dictionary<string, Tld> TldsDict = new Dictionary<string, Tld>()
        {
                { TldConsts.COM, new Tld(TldConsts.COM) },
                { TldConsts.ORG, new Tld(TldConsts.ORG) },
                { TldConsts.NET, new Tld(TldConsts.NET) },
                { TldConsts.INT, new Tld(TldConsts.INT) },
                { TldConsts.EDU, new Tld(TldConsts.EDU) },
                { TldConsts.GOV, new Tld(TldConsts.GOV) },
                { TldConsts.MIL, new Tld(TldConsts.MIL) },
        };
    }
}
