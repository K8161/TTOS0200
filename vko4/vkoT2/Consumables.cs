using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkoT2
{
    class Consumables
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string TyreSize { get; set; }
        public Tyre()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Tyre(string name, string model, string tyreSize)
        {
            Name = name;
            Model = model;
            tyreSize = TyreSize;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return " Manufacturer: " + Name + " Model: " + Model + " Tyresize: " + TyreSize;
        }
    }
}