using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Rectangle : Shape
    {
        public override string Name { get; set; }
        public override double AreaValue { get; }
        public override double RadiusValue { get; }

        public Rectangle(string name, int heigth, int width)
        {
            Name = name;
            AreaValue = Area(heigth, width);
            RadiusValue = Circumference(heigth, width);
        }

        public double Area(int heigth, int width)
        {
            return (double)heigth * (double)width;
        }

        public double Circumference(int heigth, int width)
        {
            return ((double)heigth + (double)width) * 2;
        }

        public override string ToString()
        {
            return "Shape " + Name +  " Area = " + AreaValue + " Circumference " + RadiusValue;
        }
    }
}
