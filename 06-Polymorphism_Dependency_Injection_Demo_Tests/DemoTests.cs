using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_Polymorphism_Dependency_Injection_Demo.Models;
using _06_Polymorphism_Dependency_Injection_Demo.Services;

namespace _06_Polymorphism_Dependency_Injection_Demo_Tests
{
    [TestClass]
    public class DemoTests
    {
        private Employee _employeeElevator;

        [TestMethod]
        public void Employee_ElevatorSwipeTest_ShouldPrintToConsole()
        {
            //Arrange
            _employeeElevator = new Employee(new ElevatorService());

            //Act
            _employeeElevator.SwipeCard();
        }
    }
}
