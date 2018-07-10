using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise2;

namespace _03_Defining_Classes_UnitTests_2
{
    [TestClass]
    public class UnitTest1
    {
        private Developer _dev1;

        [TestInitialize]
        public void Arrange()
        {
            _dev1 = new Developer();

            _dev1.DeveloperId = 1;
            _dev1.LastName = "Smith";
            _dev1.HasPluralsight = true;
        }

        [TestMethod]
        public void CanAddDevsToList()
        {
            //Arrange
            Arrange();
            var dev2 = new Developer(2, "Doe", false);
            var dev3 = new Developer(3, "A", true);
            var team = new Team();

            //Act
            team.AddDeveloper(_dev1);
            team.AddDeveloper(dev2);
            team.AddDeveloper(dev3);

            var expected = new List<Developer>();
            expected.Add(_dev1);
            expected.Add(dev2);
            expected.Add(dev3);

            int expectedCount = expected.Count;
            var actualCount = team.GetListCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
