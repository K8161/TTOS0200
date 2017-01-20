using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T7
{
    class Synthetisator : Instruments
    {
        public int Keys { get; set; }

        // default constructor
        public Synthetisator()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Synthetisator(string manufacturer, string model, int modelYear, int keys)
            : base(manufacturer, model, modelYear)
        {
            Keys = keys;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " Amount of keys: " + Keys;
        }
    }
}
