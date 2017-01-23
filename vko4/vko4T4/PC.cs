using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T4
{
    class PC
    {
        public string Name { get; set; }
        public int Year { get; set; }
        private const int maxComponentAmount = 5;
        private int componentAmount = 0;
        public List<Component> Components { get; }

        public PC()
        {
            Components = new List<Component>();
        }

        public void AddComponent(Component component)
        {
            if (componentAmount < maxComponentAmount)
            {
                Components.Add(component);
                componentAmount++;
                Console.WriteLine("{0} {1} {2} added to PC", component.Type, component.Manufacturer, component.Model);
            }
            else
            {
                Console.WriteLine("No room for new components.");
            }
        }

        // override base class ToString()-method
        public override string ToString()
        {
            string s = "PC Name: " + Name + ", Built in " + Year + "\nComponents: ";
            foreach (Component c in Components)
            {
                if (c != null) s += "\n-" + c.ToString();
            }
            return s;
        }
    }
}