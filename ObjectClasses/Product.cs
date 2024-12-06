using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing.ObjectClasses
{
    public class Product
    {
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Product(string ownerId, string name, decimal price, int amount)
        {
            OwnerId = ownerId;
            Name = name;
            Price = price;
            Amount = amount;
        }
        public override string ToString()
        {
            CultureInfo euroCulture = new CultureInfo("fr-FR");
            return $"{Name} - {Amount} - {(Amount * Price).ToString("C", euroCulture)}";
        }
    }
}
