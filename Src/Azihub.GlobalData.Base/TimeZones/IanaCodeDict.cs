using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TimeZones
{
    public partial class IanaCode
    {
        public static Dictionary<string, IanaCode> IanaDict { get; } = new Dictionary<string, IanaCode>()
        #region Dictionary
        {
            { IanaConsts.ETC_GMT1, new IanaCode(IanaConsts.ETC_GMT1) },
        };
        #endregion
    }
}
