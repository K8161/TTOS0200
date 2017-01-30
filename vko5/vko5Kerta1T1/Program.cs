using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.vko5Kerta1T1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadingTest();
        }

        static void ReadingTest()
        {
            IOtesting ioTesting = new IOtesting();

            ioTesting.SaveText();
            ioTesting.ReadText();
        }
    }
}
