using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2
{
    class Program
    {
        static void Main(string[] args)
        {
            UseElevator();
        }

        static void UseElevator()
        {
            //luodaan hissi olio
            Elevator elevator = new Elevator();
            //hissi oletuksena 1. kerroksessa
            elevator.Floor = 1;


            for (int i = 0; i < 5; i++)
            {

            
                //näytetään kerros ja kysytään mihin halutaan
                Console.WriteLine(elevator.ToString());
                Console.WriteLine("Which floor you want to go to? ");
                elevator.Floor = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
