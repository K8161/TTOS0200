using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Nation
    {
        // properties
        public string Name { get; set; }
        public int Population { get; set; }
        public double GDP { get; set; }
        public int NuclearWeapons { get; set; }


        // method to display data
        public void PrintData()
        {
            Console.WriteLine("Info: ");
            Console.WriteLine("- Nation: " + Name);
            Console.WriteLine("- Population: " + Population);
            Console.WriteLine("- GDP: " + GDP + "trillion");
            Console.WriteLine("- Amount of Nuclear Weapons: " + NuclearWeapons);
        }


    }

}