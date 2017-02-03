using Microsoft.VisualStudio.TestTools.UnitTesting;
using vko5Kerta2T6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vko5Kerta2T6.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void InvoiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddProductTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //arrange
            double expected = 3.39;

            Invoice customer1 = new Invoice();
            customer1.CustomerName = "Katto Kassinen";

            Product shampoo = new Product();
            shampoo.Name = "Dove";
            shampoo.Price = 2.39;
            shampoo.Quantity = 1;

            Product banana = new Product();
            banana.Name = "Chiquita Banana";
            banana.Price = 0.20;
            banana.Quantity = 5; ;

            customer1.AddProduct(shampoo);
            customer1.AddProduct(banana);

            //act
            customer1.ToString();
            double actual = customer1.InvoiceTotal;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}