using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Analyst
{
    internal class Product
    {
        public string street { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int  Count { get; set; }
        public Product(string name, string type, DateTime date, decimal price, int count)
        {
            Name = name;
            Type = type;
            Date = date;
            Price = price;
            Count = count;
        }

    }
}
