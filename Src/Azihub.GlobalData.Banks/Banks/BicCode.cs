using Azihub.GlobalData.Banking.Banks.Exceptions;
using Azihub.GlobalData.Base.Country;
using System;

namespace Azihub.GlobalData.Banking.Banks
{
    public partial class BicCode : IEquatable<BicCode>
    {
        [Obsolete("Use FromString() method", true)]
        public BicCode() { }

        public const byte CODE_LENGTH = 8;
        public const byte CODE_LENGTH_WITH_BRANCH = 11;
        private BicCode(string code)
        {
            code = code.ToUpper();
            if (code.Length != CODE_LENGTH && code.Length != CODE_LENGTH_WITH_BRANCH)
                throw new InvalidPrimaryBicCode(code);
            
            // Skip Branch code
            Code = code.Substring(0, CODE_LENGTH);

            // Set country code
            CountryCode = CountryIso2Code.FromString(code.Substring(4,2));

            // Unique bank code within the country above
            BankCode = code.Substring(0,4);
        }

        public string Code { get; }
        public string BankCode { get; }
        public CountryIso2Code CountryCode { get; }

        public override string ToString()
        {
            return Code;
        }

        public static BicCode FromString(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new InvalidPrimaryBicCode(code);


            code = code.Trim().ToUpper();
            if (Codes.TryGetValue(code, out BicCode bicCode))
                return bicCode;

            throw new InvalidPrimaryBicCode(code);
        }

        public bool Equals(BicCode other)
        {
            return (Code == other.Code);
        }
    }
}
