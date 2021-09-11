using System.Collections.Generic;

namespace Azihub.GlobalData.Base.TimeZones
{
    public partial class TimeZoneId
    {
        public static Dictionary<string, TimeZoneId> TimeZoneDict { get; } = new Dictionary<string, TimeZoneId>()
        #region Dictionary
        {
            { TimeZoneConsts.DATELINE_STANDARD_TIME, new TimeZoneId(TimeZoneConsts.DATELINE_STANDARD_TIME) },
        };
        #endregion
    }
}