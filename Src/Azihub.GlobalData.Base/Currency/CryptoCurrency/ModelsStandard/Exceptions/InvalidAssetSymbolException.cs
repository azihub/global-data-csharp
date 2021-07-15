using System;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions
{
    /// <summary>
    /// Asset Symbols must be a valid 3 letter word.
    /// </summary>
    public class InvalidAssetSymbolException : Exception
    {
        public InvalidAssetSymbolException()
        {
        }
    }
}