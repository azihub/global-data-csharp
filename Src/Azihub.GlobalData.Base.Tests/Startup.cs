﻿using Azihub.Utilities.Base.Settings.Interfaces;
using Azihub.GlobalData.Base.Tests.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace Azihub.GlobalData.Base.Tests
{
    
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGlobalSettings, GlobalSettings>();
            services.AddSingleton<IWorkerSettings, WorkerSettings>();
            //services.AddSingleton<AppSettings>();
        }
    }
}
