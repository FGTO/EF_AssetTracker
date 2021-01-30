using System;


namespace EF_AssetTracker.Domain
{
    public class Asset
    {
        public Office Office {get; set;}
        public string Brand {get; set;}
        public string Model {get; set;}
        public DateTime PurchaseDate {get; set;}
        public double PurchasePrice {get; set;}
        public string Currency {get; set;}
        public double ExchangeRate {get; set;}

    }
}
