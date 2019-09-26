using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product();
            myProduct.Name = "iPhone 11";
            myProduct.Price = 2000.00;

            System.Console.WriteLine($"{myProduct.Name} is ${myProduct.Price}, ${myProduct.PriceWithTax()} with tax");
        }
    }
}
