using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_Exercise_3;


namespace _04_Encapsulation_UnitTests3
{
    [TestClass]
    public class RateTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Age must be between 16 and 25")]
        public void InvalidAge_OutOfRangeExceptionThrown()
        {
            //Arrange
            YoungDrivers tooYoung = new YoungDrivers(15);
        }

        [TestMethod]
        public void CanTestRate_16to19()
        {
            //Arrange
            YoungDrivers eighteen = new YoungDrivers(18);

            //Act
            double expected = 228;
            double actual = eighteen.MonthlyInsuranceRate;
            Console.WriteLine($"{eighteen.MonthlyInsuranceRate}");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
