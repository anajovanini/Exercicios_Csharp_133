using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_133.Entities
{
    class UsedProduct : CommonProduct
    {
        public string ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, string manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + ($"(Manufacture date #{ManufactureDate})");
        }
    }
}
