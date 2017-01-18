using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void Accelerate()
        {
            Speed += 5;
        }

        // method to slow down
        public void Brake()
        {
            Speed -= 5;
        }

        public void Blacken()
        {
            Color = "Black";
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- name : " + Name);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- tyres : " + Tyres);
        }

        public override string ToString()
        {
            return Name + ", väri: " + Color + ", nopeus: " + Speed + " km/h, " + Tyres + " kpl renkaita";
        }


    }

}
