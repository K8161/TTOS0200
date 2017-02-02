using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            try
            {
                Console.WriteLine("Sum of array is " + ArrayCalcs.Sum(array));
                Console.WriteLine("Average of array is " + ArrayCalcs.Average(array));
                Console.WriteLine("Lowest number in array is " + ArrayCalcs.Min(array));
                Console.WriteLine("Highest number in array is " + ArrayCalcs.Max(array));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
