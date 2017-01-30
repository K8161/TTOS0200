using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.vko5Kerta1T2
{
    class FileHandler
    {
        public void ReadFile()
        {
            try
            {
                /*     string[] lines = System.IO.File.ReadAllLines(@"..\..\test.txt");
                     foreach (string line in lines)
                     {
                         Console.WriteLine(line);
                     }
                     Console.WriteLine("Found " + lines.Length + " lines."); */

                var nameCount = new Dictionary<string, int>();

                String[] lines = File.ReadAllLines(@"..\..\test.txt");
                Console.WriteLine("Found " + lines.Length + " lines.");
                foreach (String s in File.ReadAllLines(@"..\..\test.txt"))
                {
                    if (nameCount.ContainsKey(s))
                    {
                        nameCount[s] = nameCount[s] + 1;
                    }
                    else
                    {
                        nameCount.Add(s, 1);
                    }
                }

                // and printing
                foreach (var pair in nameCount)
                {
                    Console.WriteLine("{0} found: {1} times", pair.Key, pair.Value);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
