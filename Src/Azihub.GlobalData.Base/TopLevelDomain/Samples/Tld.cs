using Azihub.GlobalData.Base.TopLevelDomain.Exceptions;
using System;

namespace Azihub.GlobalData.Base.TopLevelDomain.Samples
{
    public partial class Tld : IEquatable<Tld>
    {
        private Tld(string value)
        {
            Code = value;
        }
        public string Code { get; set; }

        public static Tld FromString(string tldString)
        {
            tldString = tldString.Trim().ToLower();

            if (string.IsNullOrEmpty(tldString))
                throw new InvalidTopLevelDomainException(tldString);

            if (TldsDict.TryGetValue(tldString, out Tld tldAddress))
                return tldAddress;

            throw new InvalidTopLevelDomainException(tldString);
        }


        /// <summary>
        /// Validate a Top Level Domain
        /// </summary>
        /// <param name="tld"></param>
        /// <returns></returns>
        public static bool IsValid(string tldString)
        {
            tldString = tldString.Trim().ToLower();

            if (string.IsNullOrEmpty(tldString))
                return false;

            if (TldsDict.ContainsKey(tldString))
                return true;

            return false;
        }

        public bool Equals(Tld other)
        {
            return Code == other.Code;
        }
    }
}
