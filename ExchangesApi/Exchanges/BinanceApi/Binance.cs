using ExchangesApi.Exchanges.BinanceApi.ApiCalls;
using ExchangesApi.Exchanges.BinanceApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangesApi.Exchanges.BinanceApi
{
    public class Binance
    {
        private readonly PublicMethods PublicApi;
        private readonly PrivateMethods PrivateApi;

        public Binance(Maybe<IDownloadData> downloader)
        {
            // If a downloader is not provided, create the default
            if (!downloader.Any())
            {
                downloader = new Maybe<IDownloadData>(
                    new DownloadData(Constants.Endpoint, Constants.AbsolutePath)
                );
            }

            // We can call Single() safely because we are sure there is only one
            // instance of IDownloadData inside the Maybe
            PublicApi = new PublicMethods(downloader.Single());
            PrivateApi = new PrivateMethods();
        }

        public async Task<ExchangeInfo> ExchangeInfo()
        {
            try
            {
                return await PublicApi.ExchangeInfo();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Orderbook> Depth(string marketSymbol, int limit = 100)
        {
            try
            {
                return await PublicApi.Depth(marketSymbol, limit.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<Ticker>> BookTicker(Maybe<string> marketSymbol)
        {
            try
            {
                return await PublicApi.BookTicker(marketSymbol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<LastPriceTicker>> TickerPrice(string symbol = "")
        {
            try
            {
                return await PublicApi.TickerPrice(symbol);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
