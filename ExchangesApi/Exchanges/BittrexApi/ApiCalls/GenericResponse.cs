﻿namespace ExchangesApi.Exchanges.BittrexApi.ApiCalls
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}