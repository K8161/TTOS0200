using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            T4();
        }
        
        static void T4()
        {
            Shape circle1 = new Circle();
            circle1.Name = "Testcircle";
            circle1.RadiusValue = 1;

            Shape rectangle1 = new Rectangle();
            rectangle1.Name = "Testrectangle";
            rectangle1.Heigth = 15;
            rectangle1.Width = 15;

          //  Sh

            circle1.Area();
            circle1.Circumference();

            rectangle1.Area();
            rectangle1.Circumference();

        }
    }
}
