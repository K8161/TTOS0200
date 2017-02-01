using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestShoppingCart();
        }

        static void TestShoppingCart()
        {
            List<Product> products = new List<Product>();

            Product beer = new Product();
            beer.Name = "Olvi III";
            beer.Price = 0.89;

            Product vodka = new Product();
            vodka.Name = "Stolichnaya";
            vodka.Price = 17.89;

            Product chicken = new Product();
            chicken.Name = "Fried chicken";
            beer.Price = 4.99;

            products.Add(beer);
            products.Add(vodka);
            products.Add(chicken);

            foreach (Product product in products)
            { Console.WriteLine(products.ToString()); }
        }
    }
}
