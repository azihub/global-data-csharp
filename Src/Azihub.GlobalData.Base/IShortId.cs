using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base
{
    /// <summary>
    /// 16-bit Ensure transport and storing ID or code uses minimized footprint,
    /// the system will use dictionary to map UShort ID to String value.
    /// </summary>
    public interface IShortId
    {
        ushort Id { get; }
        string Code { get; }
    }
}
