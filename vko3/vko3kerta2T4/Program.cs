using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff();
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
