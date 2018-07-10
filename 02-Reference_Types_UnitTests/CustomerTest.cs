using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_Reference_Types;

namespace _02_Reference_Types_UnitTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerPropertiesCanBeSet()
        {

            //arrange
            Customer customer = new Customer();

            //act
            customer.FirstName = "Kevin";
            string expected = "Kevin";
            Console.WriteLine(expected);
            var actual = customer.FirstName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanAddAccidents()
        {
            //arrange
            var customer = new Customer("Kevin", "kevin@kevin.com", "1234567", 0);

            //act
            customer.AddAccidents(2);
            int expected = 2;
            Console.WriteLine(expected);
            var actual = customer.Accidents;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
