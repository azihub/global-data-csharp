namespace Azihub.GlobalData.Base.Currency.Interfaces
{
    public interface ICurrencyCode : IShortId
    {
        CurrencyType CurrencyType { get; }
    }

    public enum CurrencyType
    {
        Fiat,
        Crypto
    }
}
