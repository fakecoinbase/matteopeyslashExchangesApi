﻿namespace ExchangesApi.Exchanges.CoinbaseProApi.ApiCalls
{
    public class Candle
    {
        public long Time { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }
}
