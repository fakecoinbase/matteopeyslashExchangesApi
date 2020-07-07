﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExchangesApi.Exchanges.BinanceApi.Model
{
    public class SubscribeMessage
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public List<string> Params { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
