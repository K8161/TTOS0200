using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T4
{
    class Bike : Ride
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        // default constructor
        public Boss()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Boss(string fullName, string profession, string salary, string car, int bonus)
            : base(fullName, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        // just one method what Teacher can do 
        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Car: " + Car + " Bonus: " + Bonus;
        }
    }
}
