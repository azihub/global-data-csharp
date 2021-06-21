using System;
using Azihub.GlobalData.Base.Currency.Interfaces;

namespace Azihub.GlobalData.Base.Currency
{
    class GdCurrencyCrypto : ICurrency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public byte DecimalCount { get; set; }
        /// <summary>
        /// Minimum Block to display for currency with high quantity like Indonesian Rupee or Japan's Yen
        /// </summary>
        public uint ExchangeBlock { get; set; }

        public ulong MaxSupply { get; set; }
        public Uri OfficialWebsite { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
