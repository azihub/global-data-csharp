using Azihub.Utilities.Base.Settings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azihub.GlobalData.Base.Tests.Settings
{
    public class WorkerSettings : IWorkerSettings
    {
        public string CoinmarketcapApiKey { get; set; }
    }
}
