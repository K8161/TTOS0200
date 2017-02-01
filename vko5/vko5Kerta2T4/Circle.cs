using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Circle : Shape
    {
       // public double RadiusValue;
        public double AreaValue;
        public double CircumferenceValue;
        public override void Area()
        {
            Console.WriteLine("Radius = " + RadiusValue + " Area = " + RadiusValue * Math.PI);
        }
        public override void Circumference()
        {
            Console.WriteLine("Circumference = " + RadiusValue * Math.PI * 2);
        }
    }
}
