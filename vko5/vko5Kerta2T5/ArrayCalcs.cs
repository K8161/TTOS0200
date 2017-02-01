using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T5
{
        interface IArrayCalcs
        {
            int Sum(int number1, int number2);
            int Average(int number1, int number2);
            int Division(int number1, int number2);
            int Subtract(int number1, int number2);
        }

        public class ArrayCalcs : IArrayCalcs
        {

            public int Add(int n1, int n2)
            {
                return n1 + n2;
            }
            public int Multiply(int n1, int n2)
            {
                return n1 * n2;
            }
            public int Division(int n1, int n2)
            {
                return n1 / n2;
            }
            public int Subtract(int n1, int n2)
            {
                return n1 - n2;
            }
        }
    }

