using System;
using System.Collections.Generic;
using System.Text;

namespace Azihub.GlobalData.Base.TopLevelDomain.Exceptions
{
    public class InvalidTopLevelDomainException : Exception
    {
        public InvalidTopLevelDomainException(string address)
            : base($"Invalid TLD: {address}")
        {
            Address = address;
        }

        public string Address { get; }
    }
}
