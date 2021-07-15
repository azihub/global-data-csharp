using System;

namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Exceptions
{
    /// <summary>
    /// AssetSymbol's code was not found in dictionary
    /// </summary>
    public class AssetWasNotFoundException : Exception
    {
        public AssetWasNotFoundException(string code) : base($"Asset code: {code} was not found in internal dictionary.")
        {
        }
    }
}