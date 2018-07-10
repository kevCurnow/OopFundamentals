using System;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise3;

namespace _03_Defining_Classes_UnitTests_3
{
    [TestClass]
    public class UnitTest1
    {
        private Customer _customer;
        private CustomerRepository _customerRepository;

        [TestInitialize]
        public void Arrange()
        {
            _customer = new Customer(1, "Bon Jovi", 55, 40);
            _customerRepository = new CustomerRepository();
        }

        [TestMethod]
        public void CustomerEmail_ReturnString()
        {
            //Act
            var actual = _customerRepository.EmailCustomer(_customer);

            var expected = "You're a beast.";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
