using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_133.Entities
{
    class CommonProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public CommonProduct()
        {
        }

        public CommonProduct(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return "Name: " + Name + "Preço: " + Price;
        }
    }
}
