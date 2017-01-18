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
            //UseElevator();
            //UseAmplifier();
            //Staff();
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

        static void Staff()
        {
            // create a one Person object
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Kahvinkeittäjä";
            employee.Salary = "1624";
            Console.WriteLine(employee.ToString());

            // create a one Teacher Object
            Boss boss = new Boss();
            boss.Name = "Teppo Tulppu";
            boss.Profession = "Iso Pamppu";
            boss.Salary = "5000";
            boss.Car = "Porsche";
            boss.Bonus = 666;
            Console.WriteLine(boss.ToString());


            // do something methods
            employee.EmployeeMethod(); // This method belongs to Person!
            boss.BossMethod(); // This method belongs to Person! (derived class can use it!)
        }
    }
}
