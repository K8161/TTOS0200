using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Circle : Shape
    {
        public override string Name { get; set; }
        public override double AreaValue { get; }
        public override double RadiusValue { get; }

        public Circle(string name, int radius)
        {
            Name = name;
            AreaValue = Area(radius);
            RadiusValue = Circumference(radius);
        }

        public double Area(int radius)
        {
            return (double)radius * radius * Math.PI;
        }

        public double Circumference(double radius)
        {
            return (double)2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return "Shape " + Name + " Area = " + AreaValue + " Circumference " + RadiusValue;
        }
    }
}
