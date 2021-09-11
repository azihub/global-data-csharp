namespace Azihub.GlobalData.Base.Currency.Interfaces
{
    public interface ICurrency
    {
        ushort Id { get; }
        string Code { get; }
        string Name { get; }
        string Symbol { get; }
        byte DecimalCount { get; }
        /// <summary>
        /// Minimum Block to display for currency with high quantity like Indonesian Rupee or Japan's Yen
        /// </summary>
        uint ExchangeBlock { get; }
    }
}
