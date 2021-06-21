using System;

namespace GlobalData.Base.Country.Exceptions
{
    /// <summary>
    /// User tried to parse a country code that does not exist.
    /// </summary>
    public class InvalidCountryCodeException : Exception
    {
        public InvalidCountryCodeException(string invalidCode) : 
            base($"Invalid Country Code was provided: {invalidCode}")
        {
        }
    }
}