using Azihub.Utilities.Base.Settings;
using Azihub.Utilities.Base.Settings.Interfaces;
using Azihub.Utilities.Base.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azihub.GlobalData.Base.Tests.Settings
{
    public static class AppSettings
    {
        static AppSettings() 
        {
            DotEnv.Load();
            Global = DotEnv.Load<GlobalSettings>();
        }

        public static GlobalSettings Global { get; }
    }
}
