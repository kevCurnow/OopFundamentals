using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_Exercise1;


namespace _04_Encapsulation_UnitTests_1
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "First name cannot be empty.")]
        public void TestingInvalidFirstName_ExceptionShouldBeThrown()
        {
            //Arrange
            Customer invalidName = new Customer(null, " bob ", 200);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The age is not within the proper range.")]
        public void TestingInvalidAge_ArgumentExceptionShouldBeThrown()
        {
            //Arrange
            Customer invalidAge = new Customer("Kevin", "Curnow", 200);
        }
    }
}
