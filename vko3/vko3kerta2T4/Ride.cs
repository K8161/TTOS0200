using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T4
{
    class Ride
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        // default constructor
        public Ride()
        {
        }

        // constructor takes person firstname and lastname as a parameter
        public Ride(string name, string model, int modelYear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelYear;
            Color = color;
        }

        // just testing methods
        public void RideMethod()
        {
            Console.WriteLine("This method belongs to Ride!");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " ModelYear: " + ModelYear + " Color: " + Color;
        }
    }
}