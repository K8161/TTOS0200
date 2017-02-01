using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T1
{
    class Dice
    {
       // private int diceValue;
     //   private bool isValueValid;
        private const int maxDiceValue = 6;
        private const int minDiceValue = 1;

        public List<Dice> diceThrows = new List<Dice>();

        Random rnd = new Random();

        public int DiceValue;

        public void ThrowDice()
        {
            DiceValue = rnd.Next(minDiceValue, maxDiceValue);
            Console.WriteLine(DiceValue);
          //  Dice dice = new Dice ();
            diceThrows.Add(new Dice());
        }

        public void ShowResults()
        {
            foreach (var item in diceThrows)
            { Console.WriteLine("Number: " + DiceValue); }
        }
    }
}
