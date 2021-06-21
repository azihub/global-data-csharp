namespace Azihub.GlobalData.Base.Currency.Interfaces
{
    public interface ICurrency
    {
        string Code { get; set; }
        string Name { get; set; }
        string Symbol { get; set; }
        byte DecimalCount { get; set; }
        /// <summary>
        /// Minimum Block to display for currency with high quantity like Indonesian Rupee or Japan's Yen
        /// </summary>
        uint ExchangeBlock { get; set; }
    }
}
