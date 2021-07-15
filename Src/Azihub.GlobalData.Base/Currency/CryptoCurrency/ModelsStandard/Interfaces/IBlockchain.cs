namespace Azihub.GlobalData.Base.Currency.CryptoCurrency.ModelsStandard.Interfaces
{
    public interface IBlockchain
    {
        string Code { get; }
        byte Decimal { get; }
        string Name { get; }
    }
}