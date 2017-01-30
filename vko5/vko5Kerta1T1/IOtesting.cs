using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.vko5Kerta1T1
{
    class IOtesting
    {
        public string Text { get; set; }

        public void SaveText()
        {
            StreamWriter outputFile = null;

            try
            {
                Console.WriteLine("Welcome to textsaver Pro 2000!");
                outputFile = new System.IO.StreamWriter(@"..\..\SavedText.txt");
                do
                {
                    Console.WriteLine("Give text to save: ");
                    Text = Console.ReadLine();
                    outputFile.WriteLine(Text);
                } while (Text != String.Empty);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }

        public void ReadText()
        {
            // @"D:\K8161\TTOS0200\vko5\vko5Kerta1T1\SavedText.txt"
            try
            {
            string text = System.IO.File.ReadAllText(@"..\..\SavedText.txt");
        System.Console.WriteLine("Your nonsense printed:\n" + text);
        } catch (FileNotFoundException)
        {
            Console.WriteLine("File not found (FileNotFoundException)");
        }
      }
    }
}
