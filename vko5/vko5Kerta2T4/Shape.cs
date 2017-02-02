using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    abstract class Shape 
    {
        virtual public string Name { get; set; }
        virtual public double RadiusValue { get; }
        virtual public double AreaValue { get; }
        //       virtual public double Width;
        //     virtual public double Heigth;

        public Shape()
        {
        }

        public Shape(string name)
        {
            Name = name;
        }

  /*      public void DoSomething()
        {
            Console.WriteLine("Do something!");
        } */

        virtual public void Area()
        { }
        virtual public void Circumference()
        { }
    }
}
