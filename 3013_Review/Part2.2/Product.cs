using System;
using System.Collections.Generic;
using System.Text;

namespace Part2._2
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            Name = string.Empty;
            Price = 0;
            Category = string.Empty;
            Quantity = 0;
        }

        public double GetInventoryValue()
        {
            return Price * Quantity;
        }

    }
}
