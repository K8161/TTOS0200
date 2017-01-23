using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkoT2
{
    class Fridge
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        private const int maxProductAmount = 12;
        private const int minProductAmount = 0;
        private int productAmount = 0;
        public List<Consumable> Consumables { get; }

        public Fridge()
        {
            Consumables = new List<Consumable>();
        }

        //method to add products to fridge
        public void AddConsumable(Consumable consumable)
        {
            if (productAmount < maxProductAmount)
            {
                Consumables.Add(consumable);
                productAmount++;
                Console.WriteLine("{0} {1} {2} added to fridge.", consumable.ProductType, consumable.Name, consumable.Size);
            }
            else
            {
                Console.WriteLine("Fridge is full!");
            }
        }

        //method to remove products from fridge
        public void RemoveConsumable(Consumable consumable)
        {
            if (productAmount > minProductAmount)
            {
                Consumables.Remove(consumable);
                productAmount--;
                Console.WriteLine("{0} {1} {2} consumed.", consumable.ProductType, consumable.Name, consumable.Size);
            }
            else
            {
                Console.WriteLine("Fridge is empty!");
            }
        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "Fridge manufacturer: " + Manufacturer + " Model: " + Model + "\nContent: ";
            foreach (Consumable c in Consumables)
            {
                if (s != null) s += "\n-" + c.ToString();
            }
            return s;
        }
    }
}