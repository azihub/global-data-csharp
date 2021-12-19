using System;

namespace Azihub.GlobalData.Banking.Banks.Exceptions
{
    public class InvalidPrimaryBicCode : Exception
    {
        public InvalidPrimaryBicCode(string code) :
            base($"Primary BIC code (without branch) must be {BicCode.CODE_LENGTH} letters long: {code}")
        { }
    }
}
