using System;
using ConsoleApp;

namespace EF_AssetTracker.Domain
{
    public class ExchangeRate
    {
        public ExchangeRate(string currency, double rate)
        {
            Currency = currency;
            Rate = rate;
        }
        public string Currency {get; set;}
        public double Rate {get; set;}
    }
}
