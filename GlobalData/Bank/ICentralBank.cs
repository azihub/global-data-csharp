using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalData.Bank
{
    public interface ICentralBank
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
        public string Website { get; set; }
    }

    public class CentralBankUnion : ICentralBank
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
        public string Website { get; set; }
    }
}
