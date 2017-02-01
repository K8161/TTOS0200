using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T3
{
    class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        private const int maxProductAmount = 12;
        public List<Fish> Fishes { get; }

        public Fisher()
        {
            Fishes = new List<Fish>();
        }

        //method to add fishes to fisher
        public void AddFish(Fish fish)
        {
                Fishes.Add(fish);
                Console.WriteLine("{0} caught {1}!", Name, fish.Specie);

        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "Fisher: " + Name + " got following fishes \n";
            foreach (Fish f in Fishes)
            {
                if (s != null) s += "\n-" + f.ToString();
            }
            return s;
        }
    }
}
