using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Analyst
{
    internal class Product
    {
        public string Street { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        private double _priceForOne = 0;
        public double PriceForOne { get { return _priceForOne; } }
        public int Count { get; set; } 
        public Product(string name, string type, DateTime date, double price, int count, string street)
        {
            Name = name;
            Type = type;
            Date = date;
            Price = price;
            Count = count;
            Street = street;
            _priceForOne = Price / Count;
        }
        public Product(Product product) : this(product.Name, product.Type, product.Date, product.Price, product.Count, product.Street) { }
        public void AddCountAndPrice(int count, double price)
        {
            Price += price;
            Count += count;
            _priceForOne = Price/Count;
            Price = Math.Round(Price,2);
            _priceForOne = Math.Round(PriceForOne, 2);
        }
    }
}
