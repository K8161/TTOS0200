using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkoT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht1();
        }
        static void Teht1()
        {
            //create Fridge object
            Fridge fridge1 = new Fridge();
            fridge1.Manufacturer = "Siemens";
            fridge1.Model = "SN2000ZNS";

            //create beer object
            Consumable beer = new Consumable();
            beer.ProductType = "Beer";
            beer.Name = "Olvi III";
            beer.Size = "0,33l";

            //create sausage object
            Consumable sausage = new Consumable();
            sausage.ProductType = "Sausage";
            sausage.Name = "Wilhelm";
            sausage.Size = "400g";

            //adding products to fridge
            fridge1.AddConsumable(beer);
            fridge1.AddConsumable(beer);
            fridge1.AddConsumable(sausage);
            fridge1.AddConsumable(sausage);
            Console.WriteLine(fridge1.ToString());

            //removing products from fridge
            fridge1.RemoveConsumable(beer);
            fridge1.RemoveConsumable(beer);
            fridge1.RemoveConsumable(sausage);
            fridge1.RemoveConsumable(sausage);
            Console.WriteLine(fridge1.ToString());
        }
    }
}