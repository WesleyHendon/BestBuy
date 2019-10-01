using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product();
            myProduct.Name = "iPhone 11";
            myProduct.Price = 1999.99;

            Console.WriteLine($"{myProduct.Name} is ${myProduct.Price}, ${myProduct.PriceWithTax()} with tax");
        }
    }
}
