using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T4
{
    class Bike : Ride
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        // default constructor
        public Bike()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Bike(string name, string model, int modelyear, string color, bool gearwheels, string gearname)
            : base(name, model, modelyear, color)
        {
            GearWheels = gearwheels;
            GearName = gearname;
        }

        // just testing methods 
        public void BikeMethod()
        {
            Console.WriteLine("This method belongs to Bike!");
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " GearWheels: " + GearWheels + " Gear Name: " + GearName;
        }
    }
}
