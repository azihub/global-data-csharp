using System;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions
{
    public class InvalidBlockchainCodeException : Exception
    {
        public InvalidBlockchainCodeException(string code) : base($"Invalid Blockchain code: {code}") { }
    }
}
