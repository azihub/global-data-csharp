using NoobsMuc.Coinmarketcap.Client;
using System;
using Xunit;
using Xunit.Abstractions;
using Azihub.Utilities.Base.Tests;
using CmcCurrency = NoobsMuc.Coinmarketcap.Client.Currency;
using static Azihub.GlobalData.Base.Tests.Settings.AppSettings;
using System.Linq;
using System.Collections.Generic;
using CoinMarketCap;
using CoinMarketCap.Models.Cryptocurrency;
using CoinMarketCap.Models;
using CoinMarketCap.Options;
using CoinGecko.Clients;

namespace Azihub.GlobalData.Base.Tests.Currency
{
    public class GdCryptoTests : TestBase
    {
        public GdCryptoTests(ITestOutputHelper output) : base(output)
        {

        }

        [Fact]
        public void GetCoinCapListingsNoobsMucTest()
        {
            ICoinmarketcapClient client = new CoinmarketcapClient(Global.CoinmarketcapApiKey);
            var currencies = client.GetCurrencies(5000);
            Output.WriteLine(
                string.Join(",\n", currencies.Select(c => String.Concat(c.Id, ":", c.Name, ":", c.Symbol)).ToArray())
            );
        }

        [Fact]
        public void GetCoinCapListingsIzehrungTest()
        {
            var client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            IdMapParameters parameters = new IdMapParameters {  };
            Response<List<IdMap>> response = client.GetCryptocurrencyIdMap(parameters);
            List<IdMap> currencies = response.Data;
            Output.WriteLine(
               string.Join(",\n", currencies.Select(c => String.Concat(c.Id, ":", c.Name, ":", c.Symbol, ":Slug=", c.Slug)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }

        [Fact]
        public void GetCoinCapCoinDataIzehrungTest()
        {
            var client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            MetadataParameters parameters = new MetadataParameters {
                Id = new long[] { CryptocurrencyId.Bitcoin } 
            };
            Response<List<Metadata>> response = client.GetCryptocurrencyInfo(parameters);
            List<Metadata> currencies = response.Data;
            Output.WriteLine(
               string.Join(",\n", currencies.Select(c => String.Concat(c.Id, ":", c.Name, ":", c.Symbol, ":Slug=", c.Slug, ":Logo=", c.Logo, ":SourceCode=", c.Urls.SourceCode)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }

        [Fact]
        public void GetCoinGeckoGetListTest()
        {
            var client = CoinGeckoClient.Instance;

            var currencies = client.CoinsClient.GetAllCoinsData("id", 5000, 1,"en",false).GetAwaiter().GetResult();
            Output.WriteLine(
               string.Join(",\n", currencies.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol, ":Slug=", c.Localization)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }
    }
}