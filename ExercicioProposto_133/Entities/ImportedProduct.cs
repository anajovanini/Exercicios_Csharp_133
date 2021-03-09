using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_133.Entities
{
    class ImportedProduct : CommonProduct
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            double price2 = Price + CustomsFee;
            return base.PriceTag() + price2 + ($"(Customs fee: $ #{CustomsFee})");
        }
    }
}
