using Azihub.GlobalData.Base.TopLevelDomain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TopLevelDomain
{
    public partial class Tld
    {
        private Tld(string value)
        {
            Value = value;
        }
        public string Value { get; set; }

        public static Tld FromString(string tldString)
        {
            tldString = tldString.Trim().ToLower();

            if (string.IsNullOrEmpty(tldString))
                throw new InvalidTopLevelDomainException(tldString);

            if (TldsDict.TryGetValue(tldString, out Tld tldAddress))
                return tldAddress;

            throw new InvalidTopLevelDomainException(tldString);
        }
    }
}
