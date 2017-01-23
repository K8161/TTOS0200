using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T1
{
    class Vehicle
    {
        public string VehicleType { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        private const int maxTyreCount = 4;
        private int TyreCount = 0;
        public List<Tyre> Tyres { get; }
        
        public Vehicle()
        {
            Tyres = new List<Tyre>();
        }

        public void AddTyre(Tyre tyre)
        {
            if (TyreCount < maxTyreCount)
            { Tyres.Add(tyre);
                TyreCount++;
                Console.WriteLine("Tyre {0} added to vehicle {1}", tyre.Model, Name);
            }
            else
            {
                Console.WriteLine("No room for new tyres.");
            }
        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "Vehicle Name: " + Name + "Model: " + Model + "\nRenkaat: ";
            foreach(Tyre t in Tyres)
            {
                if (t != null) s += "\n-" + t.ToString();
            }
            return s;
        }
    }
}