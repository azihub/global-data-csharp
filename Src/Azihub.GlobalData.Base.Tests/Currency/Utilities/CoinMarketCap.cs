using CoinMarketCap;
using CoinMarketCap.Models;
using CoinMarketCap.Models.Cryptocurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azihub.GlobalData.Base.Tests.Currency.Utilities
{
    public class CoinMarketCap
    {
        public CoinMarketCap(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string ApiKey { get; }

        public List<Metadata> GetAllCryptos()
        {
            var client = new CoinMarketCapClient(ApiKey);
            MetadataParameters parameters = new();
            Response<List<Metadata>> response = client.GetCryptocurrencyInfo(parameters);
            return response.Data;
        }
    }
}
