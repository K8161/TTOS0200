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

        static void UseRadio()
        {
            //creating radio object
            Radio radio = new Radio();
            radio.IsOn = true;
            //volume is set to 5 by default
            radio.Volume = 5;
            //Frequency is set to 2800 by default
            radio.Frequency = 2800;

            Console.WriteLine("Radio is on: {0}", radio.IsOn);

            if (radio.IsOn == true)
            {
                for (int i = 0; i < 5; i++)
                {


                    //show Volume and ask how much Volume is wanted
                    Console.WriteLine(radio.ToString());
                    Console.WriteLine("How much volume is wanted? ");
                    radio.Volume = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Which frequency is wanted? ");
                    radio.Frequency = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}