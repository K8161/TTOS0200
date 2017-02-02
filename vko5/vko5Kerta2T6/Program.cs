using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping();
        }
        static void Shopping()
        {
            //create Customer
            Invoice customer1 = new Invoice();
            customer1.CustomerName = "Katto Kassinen";

            //create product
            Product shampoo = new Product();
            shampoo.Name = "Dove";
            shampoo.Price = 2.39;
            shampoo.Quantity = 1;

            //create product
            Product banana = new Product();
            banana.Name = "Chiquita Banana";
            shampoo.Price = 0.20;
            shampoo.Quantity = 5; ;

            //adding products to invoice
            customer1.AddProduct(shampoo);
            customer1.AddProduct(banana);


            Console.WriteLine(customer1.ToString());
            
        }
    }
}
