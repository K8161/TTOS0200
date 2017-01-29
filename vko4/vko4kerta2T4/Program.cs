using System;
using System.Collections.Generic;
using System.IO;
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
            //create team object
            Team jyp = new Team();
            jyp.TeamName = "JYP";
            jyp.HomeCity = "Jyväskylä";

            //print team data with players
            jyp.ToString();

            //save team data
            jyp.SaveTeam();

            //just testing reading directly from file
            string text = File.ReadAllText("Players.txt");
            Console.WriteLine(text);
        }
    }
}
