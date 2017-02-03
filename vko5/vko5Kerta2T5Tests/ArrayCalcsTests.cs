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
            double sumAnswer = 0;
            double[] array = { 1.0, 2.0 };
            int expected = 3;

            //act
            int actual = calc.Sum(array);

            //assert
            Assert.AreEqual(expected, actual);

            //ja toinen testi Add-metodilla
            a = 0;
            b = 1;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MinTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MaxTest()
        {
            Assert.Fail();
        }
    }
}