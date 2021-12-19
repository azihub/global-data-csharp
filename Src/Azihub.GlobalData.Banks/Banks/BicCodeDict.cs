using System.Collections.Generic;

namespace Azihub.GlobalData.Banking.Banks
{
    public partial class BicCode
    {
        public static Dictionary<string, BicCode> Codes { get; } = new Dictionary<string, BicCode>()
        #region Dictionary
        {
            {BicCodesConsts.MY_CIMB_KL, new BicCode(BicCodesConsts.MY_CIMB_KL)},
        };
        #endregion
    }
}
