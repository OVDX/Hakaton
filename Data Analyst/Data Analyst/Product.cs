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
        public double PriceForOne { get; }
        public int Count { get; set; } 
        public Product(string name, string type, DateTime date, double price, int count, string street)
        {
            Name = name;
            Type = type;
            Date = date;
            Price = price;
            Count = count;
            Street = street;
            PriceForOne = Price / Count;
        }

    }
}
