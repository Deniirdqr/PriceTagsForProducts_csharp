using System;
using System.Globalization;

namespace Oitavo_Produtos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
