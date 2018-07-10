using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise1;

namespace _03_Defining_Classes_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            //Arrange
            _employee = new Employee();

            _employee.EmployeeId = 1;
            _employee.LastName = "Curnow";
            _employee.Age = 24;
            _employee.NumberOfYears = 1;
        }

        [TestMethod]
        public void CanCreateEmployee()
        {
            //Arrange
            var employee = new Employee(1, "Curnow", 24, 1);

            //Act
            int expectedId = 1;
            string expectedName = "Curnow";
            int expectedAge = 24;
            int expectedYears = 1;

            var actualId = employee.EmployeeId;
            var actualName = employee.LastName;
            var actualAge = employee.Age;
            var actualYears = employee.NumberOfYears;

            //Assert
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedAge, actualAge);
            Assert.AreEqual(expectedYears, actualYears);
        }

        [TestMethod]
        public void CheckConstructorForEmployeeId()
        {
            //Arrange
            Arrange();

            //Act
            int expectedId = 1;
            var actualId = _employee.EmployeeId;

            //Assert
            Assert.AreEqual(expectedId, actualId);

        }
    }
}
