using Microsoft.VisualStudio.TestTools.UnitTesting;
using vko5Kerta2T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //arrange
            ArrayCalcs calc = new ArrayCalcs();
            double[] array = { 1.0, 2.0 };
            double expected = 3;

            //act
            double actual = ArrayCalcs.Sum(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EmptySumTest()
        {
            //arrange
            ArrayCalcs calc = new ArrayCalcs();
            double[] array = { };
            double expected;

            //act
            double actual = ArrayCalcs.Sum(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            //arrange
            ArrayCalcs calc = new ArrayCalcs();
            double[] array = { 1.0, 2.0, 3.0 };
            double expected = 2.0;

            //act
            double actual = ArrayCalcs.Average(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            //arrange
            ArrayCalcs calc = new ArrayCalcs();
            double[] array = { 1.0, 2.0, 3.0 };
            double expected = 1.0;

            //act
            double actual = ArrayCalcs.Min(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            //arrange
            ArrayCalcs calc = new ArrayCalcs();
            double[] array = { 1.0, 2.0, 3.0 };
            double expected = 3.0;

            //act
            double actual = ArrayCalcs.Max(array);

            //assert
            Assert.AreEqual(expected, actual); ;
        }
    }
}