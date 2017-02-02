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
            Shapes shapes = new Shapes();

            shapes.Shapelist.Add(new Rectangle("TestSquare", 2, 3));
            shapes.Shapelist.Add(new Circle("TestBall", 3));

            foreach (Shape s in shapes.Shapelist)
            {
                Console.WriteLine(s.ToString());
            }
        }
}

}
    

