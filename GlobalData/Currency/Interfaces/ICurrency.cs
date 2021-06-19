using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalData.Currency
{
    public interface ICurrency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public byte DecimalCount { get; set; }
        /// <summary>
        /// Minimum Block to display for currency with high quantity like Indonesian Rupee or Japan's Yen
        /// </summary>
        public uint ExchangeBlock { get; set; }
    }
}
