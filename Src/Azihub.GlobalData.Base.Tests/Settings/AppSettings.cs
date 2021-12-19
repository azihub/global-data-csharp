using Azihub.Utilities.Base.Tools;

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
