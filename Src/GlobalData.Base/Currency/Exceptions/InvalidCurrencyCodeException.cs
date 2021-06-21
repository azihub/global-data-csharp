using System;

namespace GlobalData.Base.Currency.Exceptions
{
    /// <summary>
    /// User provided an invalid currency code.
    /// </summary>
    public class InvalidCurrencyCodeException : Exception
    {
        public string InvalidCurrencyCode { get; }
        public InvalidCurrencyCodeException(string invalidCurrencyCode)
            : base("User provided invalid currency code: " + invalidCurrencyCode)
        {
            InvalidCurrencyCode = invalidCurrencyCode;
        }
    }
}
