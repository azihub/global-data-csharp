using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public class Tld
    {
        public Tld(string value)
        {
            Value = value;
        }
        public string Value { get; set; }
    }
}
