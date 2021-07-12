using NoobsMuc.Coinmarketcap.Client;
using CmcCurrency = NoobsMuc.Coinmarketcap.Client.Currency;
using System;
using Xunit;
using Xunit.Abstractions;
using Azihub.Utilities.Base.Tests;

namespace Azihub.GlobalData.Base.Tests.Currency
{
    public class GdCryptoTests : TestBase
    {
        public GdCryptoTests(ITestOutputHelper output) : base(output) 
        {
            LoadEnv();
        }

        private const string COINMARKETCAP_API_KEY = "COINMARKETCAP_API_KEY";

        [Fact]
        public void GetCoinCapListingsTest()
        {
            string apiKey = Environment.GetEnvironmentVariable(COINMARKETCAP_API_KEY);
            ICoinmarketcapClient client = new CoinmarketcapClient(apiKey);
            var currency = client.GetCurrencies();
            Output.WriteLine(currency.ToString());
        }
    }
}