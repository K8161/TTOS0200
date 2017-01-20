using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T7
{
    class Guitar : Instruments
    {
        public string Pickups { get; set; }
        public string Frets { get; set; }

        // default constructor
        public Guitar()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Guitar(string manufacturer, string model, int modelYear, string pickups, string frets)
            : base(manufacturer, model, modelYear)
        {
            Pickups = pickups;
            Frets = frets;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Pickups: " + Pickups + " Frets: " + Frets;
        }
    }
}
