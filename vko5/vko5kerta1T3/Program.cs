﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5kerta1T3
{
    class Program
    {
        static void Main(string[] args)
        {
            T3();
        }

        static void T3()
        {
            Number test = new Number();

            test.SaveNumbers();

            test.ReadInts();

            test.ReadDoubles();
        }
    }
}
