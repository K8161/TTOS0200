using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T1
{
    class Dice
    {
        public int AmountOfThrows;
        public int DiceValue;
        private const int maxDiceValue = 7;
        private const int minDiceValue = 1;
        private double average;
        private double throwCounter;
        private int[] throwCount = new int[6];

        public List<Dice> diceThrows = new List<Dice>();

        Random rnd = new Random();


        public void AskUser()
        {
            Console.WriteLine("Good day sir! Let's play some dice.");
            Console.Write("How many times you would like to throw dice? ");
            AmountOfThrows = int.Parse(Console.ReadLine());
        }

        public void ThrowDice()
        {
            for (int i = 0; i < AmountOfThrows; i++)
            {
                DiceValue = rnd.Next(minDiceValue, maxDiceValue);
                Console.WriteLine("You threw " + DiceValue);
                throwCounter = throwCounter + DiceValue;
                switch (DiceValue)
                {
                    case 1: throwCount[0]++; break;
                    case 2: throwCount[1]++; break;
                    case 3: throwCount[2]++; break;
                    case 4: throwCount[3]++; break;
                    case 5: throwCount[4]++; break;
                    case 6: throwCount[5]++; break;
                    default:
                        break;
                }
                average = throwCounter / AmountOfThrows;
            }
        }

        public override string ToString()
        {
            return "Averagely your number was: " + average + "\nNumber of throws: " + AmountOfThrows +
                "\n\tNumber 1 shows up: " + throwCount[0] + " times" +
                "\n\tNumber 2 shows up: " + throwCount[1] + " times" +
                "\n\tNumber 3 shows up: " + throwCount[2] + " times" +
                "\n\tNumber 4 shows up: " + throwCount[3] + " times" +
                "\n\tNumber 5 shows up: " + throwCount[4] + " times" +
                "\n\tNumber 6 shows up: " + throwCount[5] + " times";
        }
    }
}
