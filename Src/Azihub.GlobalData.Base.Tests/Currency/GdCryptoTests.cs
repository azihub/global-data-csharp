using NoobsMuc.Coinmarketcap.Client;
using System;
using Xunit;
using Xunit.Abstractions;
using CmcCurrency = NoobsMuc.Coinmarketcap.Client.Currency;
using static Azihub.GlobalData.Base.Tests.Settings.AppSettings;
using System.Linq;
using System.Collections.Generic;
using Azihub.Utilities.Base.Tests;
using Mc2.CoinMarketCap;
using Mc2.CoinMarketCap.NetStandard.Models.Cryptocurrency;
using Mc2.CoinMarketCap.NetStandard.Models;
using Mc2.CoinMarketCap.NetStandard.Options;
using CoinGecko.Clients;
using CoinGecko.Entities.Response.Coins;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties;

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
            IEnumerable<CmcCurrency> currencies = client.GetCurrencies(5000);
            Output.WriteLine(
                string.Join(",\n", currencies.Select(c => String.Concat(c.Id, ":", c.Name, ":", c.Symbol)).ToArray())
            );
        }


        [Fact]
        public void GetCoinCapCoinDataIzehrungTest()
        {
            CoinMarketCapClient client = new(Global.CoinmarketcapApiKey);
            CryptoInfoRequest request = new(new long[] { CryptocurrencyId.BITCOIN } );
            Response<CryptoInfoResponse> response = client.GetCryptocurrencyInfo(request);
            Dictionary<string, Metadata> currencies = response.Data.MetadataDict;
            Output.WriteLine(
               string.Join(",\n", currencies.Values.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol, ":Slug=", c.Slug, ":Logo=", c.Logo, ":SourceCode=", c.UrlLinks.SourceCode)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);
        }

        [Fact]
        public void GetCoinGeckoGetListTest()
        {
            CoinGeckoClient client = CoinGeckoClient.Instance;

            IReadOnlyList<CoinFullData> currencies = client.CoinsClient.GetAllCoinsData("id", 5000, 1,"en",false).GetAwaiter().GetResult();
            Output.WriteLine(
               string.Join(",\n", currencies.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol, ":Slug=", c.Localization)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }
    }
}