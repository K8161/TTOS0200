using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T3
{
    class Fish
    {
        public string Specie { get; set; }
        public string Length { get; set; }
        public string Weight { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }

        // override base class ToString()-method
        public override string ToString()
        {
            return " Catch: " + Specie + " " + Length + "cm " + Weight + "kg \n" + "Place " + Place + " Location " + Location;
        }
    }
}
