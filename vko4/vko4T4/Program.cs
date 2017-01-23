using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht1();
        }
        static void Teht1()
        {
            //create PC object
            PC pc1 = new PC();
            pc1.Name = "Adolf";
            pc1.Year = 2016;

            //create component object
            Component component1 = new Component();
            component1.Type = "Motherboard";
            component1.Manufacturer = "Asus";
            component1.Model = "Z270-A";

            //create component object
            Component component2 = new Component();
            component2.Type = "Processor";
            component2.Manufacturer = "Intel";
            component2.Model = "i7-7700k";

            //create component object
            Component component3 = new Component();
            component3.Type = "GPU";
            component3.Manufacturer = "Asus";
            component3.Model = "Nvidia GTX 1070";

            //create component object
            Component component4 = new Component();
            component4.Type = "SSD";
            component4.Manufacturer = "Samsung";
            component4.Model = "850 EVO";

            //create component object
            Component component5 = new Component();
            component5.Type = "RAM";
            component5.Manufacturer = "Kingston";
            component5.Model = "16GB DDR4";

            pc1.AddComponent(component1);
            pc1.AddComponent(component2);
            pc1.AddComponent(component3);
            pc1.AddComponent(component4);
            pc1.AddComponent(component5);
            Console.WriteLine(pc1.ToString());
        }
    }
}
