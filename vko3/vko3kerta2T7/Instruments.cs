using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T7
{
    class Instruments
    {

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }

        // default constructor
        public Instruments()
        {
        }

        // constructor takes person firstname and lastname as a parameter
        public Instruments(string manufacturer, string model, int modelYear)
        {
            Manufacturer = manufacturer;
            Model = model;
            ModelYear = modelYear;
        }

        // return BasicInfo as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Manufacturer: " + Manufacturer + " Model: " + Model + " ModelYear: " + ModelYear;
        }
    }
}
