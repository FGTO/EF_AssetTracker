using System;
using ConsoleApp;

namespace EF_AssetTracker.Domain
{
    public class Phone : Asset
    {
        public Phone()
        {
            
        }
        public Phone(string brand, string model, DateTime purchaseDate, Office office, double purchasePrice, string currency, double exchangeRate)
        {
            Brand = brand;
            Model = model;
            PurchaseDate = purchaseDate;
            Office = office;
            PurchasePrice = purchasePrice;
            Currency = currency;
            ExchangeRate = exchangeRate;
        }

        public int PhoneID {get; set;}
    }
}
