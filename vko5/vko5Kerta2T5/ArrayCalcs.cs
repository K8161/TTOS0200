using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T5
{

        public class ArrayCalcs
        {

        public static double Sum(double[] array)
        {
            double sumAnswer = 0;

            foreach (double number in array)
            {
                sumAnswer = sumAnswer + number;
            }

            return sumAnswer;
        }

        public static double Average(double[] array)
        {
            double averageAnswer = 0;
            double sumAnswer = 0;

            foreach (double number in array)
            {
                sumAnswer = sumAnswer + number;
                averageAnswer = sumAnswer / array.Length;
            }

            return averageAnswer;
        }

        public static double Min(double[] array)
        {
            double Min = 0;

            foreach (double number in array)
            {
                Min = array.Min();
            }

            return Min;
        }

        public static double Max(double[] array)
        {
            double Max = 0;

            foreach (double number in array)
            {
                Max = array.Max();
            }

            return Max;
        }
    }
    }

