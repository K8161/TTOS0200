using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T5
{
    class Program
    {
        static void Main(string[] args)
        {
            UseRadio();
        }

        static void UseAmplifier()
        {
            //creating amplifier object
            Amplifier amplifier = new Amplifier();
            //volume is set to 20 by default
            amplifier.Volume = 20;


            for (int i = 0; i < 5; i++)
            {


                //show Volume and ask how much Volume is wanted
                Console.WriteLine(amplifier.ToString());
                Console.WriteLine("How much volume is wanted? ");
                amplifier.Volume = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}