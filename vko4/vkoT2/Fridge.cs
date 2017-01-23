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
        private int productAmount = 0;
        public List<Consumable> Consumables { get; }

        public Fridge()
        {
            Consumables = new List<Consumable>();
        }

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

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "Vehicle Name: " + Name + "Model: " + Model + "\nRenkaat: ";
            foreach (Tyre t in Tyres)
            {
                if (t != null) s += "\n-" + t.ToString();
            }
            return s;
        }
    }
}