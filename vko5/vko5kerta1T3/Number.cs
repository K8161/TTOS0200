using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5kerta1T3
{
    class Number
    {
        public string NumberValue { get; set; }

        int IntNumber;
        double DoubleNumber;

        public void SaveNumbers()
        {
            StreamWriter outputFileInts = null;
            StreamWriter outputFileDoubles = null;

            try
            {
                Console.WriteLine("Let's play with numbers!");
                outputFileInts = new System.IO.StreamWriter(@"..\..\Integers.txt");
                outputFileDoubles = new System.IO.StreamWriter(@"..\..\Doubles.txt");
                do
                {
                    Console.WriteLine("Give text to save: ");
                    NumberValue = Console.ReadLine();
                    if (int.TryParse(NumberValue, out IntNumber))
                    {
                        outputFileInts.WriteLine(IntNumber);
                    }

                    else if (double.TryParse(NumberValue, out DoubleNumber))
                    {
                        outputFileInts.WriteLine(DoubleNumber);
                    }

                    else
                    { break; }
                } while (NumberValue != String.Empty);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFileInts != null || outputFileDoubles != null)
                {
                    outputFileInts.Close();
                    outputFileDoubles.Close();
                }
            }
        }

        public void ReadInts()
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"..\..\Integers.txt");
                System.Console.WriteLine("Integers:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }

        public void ReadDoubles()
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"..\..\Doubles.txt");
                System.Console.WriteLine("Doubles:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}

