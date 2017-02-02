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
            Dice monopolDice = new Dice();

            try
            {
                monopolDice.AskUser();
           }
           catch (Exception ex)
           {

               Console.WriteLine(ex.Message);
            }

            try
            {
                monopolDice.ThrowDice();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(monopolDice.ToString());
            }
           catch (Exception ex)
           {

                Console.WriteLine(ex.Message);
             }
        }
    }
}
