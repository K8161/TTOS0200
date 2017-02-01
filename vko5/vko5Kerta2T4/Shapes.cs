using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T4
{
    class Shapes
    {
        public List<Shape> Shapelist { get; set; }
     //   List<Shape> Shapelist1 = new List<Shape>();

        public void AddShape(Shape shape)
        {
            Shapelist.Add(shape);
            Console.WriteLine("{0} added!", shape.Name );

        }
    }
}
