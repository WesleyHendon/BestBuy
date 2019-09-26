using System;
namespace BestBuy
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public double PriceWithTax()
        {
            return Price * 1.1;
        }
    }
}
