using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko4kerta2T4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestJoukkue();
        }

        static void TestJoukkue()
        {
            //create Fridge object
            Team jyp = new Team();
            jyp.TeamName = "JYP";
            jyp.HomeCity = "Jyväskylä";

            jyp.AddPlayer();
        }
    }
}
