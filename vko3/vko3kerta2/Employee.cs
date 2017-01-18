using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko3kerta2
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Salary { get; set; }

        // default constructor
        public Employee()
        {
        }

        // constructor takes person firstname and lastname as a parameter
        public Employee(string fullName, string profession, string salary)
        {
            Name = fullName;
            Profession = profession;
            Salary = salary;
        }

        // just one method what Employee can do
        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to Employee!");
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}