using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T4
{
    class Component
    {
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Component()
        {
        }

        // parametric constuctor calls base class constructor with parameters
        public Component(string type, string manufacturer, string model)
        {
            Type = type;
            Manufacturer = manufacturer;
            Model = model;
        }

        // override base class ToString()-method
        public override string ToString()
        {
            return " Type: " + Type + ", Manufacturer: " + Manufacturer + ", Model: " + Model;
        }
    }
}