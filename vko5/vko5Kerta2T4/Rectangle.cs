using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Rectangle : Shape
    {
      //  public double Width;
     //   public double Heigth;
        public double AreaValue;
        public double CircumferenceValue;
        public override void Area()
        {
            Console.WriteLine("Width = " + Width + " Heigth = " + Heigth + " Area = " + Width * Heigth);
        }
        public override void Circumference()
        {
            CircumferenceValue = Heigth + Heigth + Width + Width;
            Console.WriteLine("Circumference = " + CircumferenceValue);
        }
    }
}
