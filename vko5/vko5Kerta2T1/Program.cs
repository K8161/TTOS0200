using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T1
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceTesting();
        }
        static void DiceTesting()
        {
            string input;
            int amountOfThrows;
            Dice monopolDice = new Dice();

            Console.WriteLine("Let's throw dice! How many throws you want? ");
            input = Console.ReadLine();
            int.TryParse(input, out amountOfThrows);

            do
            {
                monopolDice.ThrowDice();
                amountOfThrows--;
            } while (amountOfThrows > 0);

            monopolDice.ShowResults();
        }
    }
}
