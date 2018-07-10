using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04_Encapsulation_Exercise2;

namespace _04_Encapsulation_UnitTests_2
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Length must be between 6 and 30 feet.")]
        public void InvalidLength_ShouldReturnOutOfRange()
        {
            //Arrange
            Room invalidLength = new Room(5, 6, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Height must be between 10 and 12 feet.")]
        public void InvalidHeight_ShouldReturnOutOfRange()
        {
            //Arrange
            Room invalidHeight = new Room(7, 7, 14);
            Console.WriteLine($"{invalidHeight.Height}");
        }

        [TestMethod]
        public void CalculateSurfaceArea_ShouldBeValid()
        {
            //Arrange
            Room validRoom = new Room(10, 10, 10);

            //Act
            var expectedSurfaceArea = 100;
            var actualSurfaceArea = validRoom.CalculateSurfaceArea();
            Console.WriteLine($"{expectedSurfaceArea}-{actualSurfaceArea}");

            //Assert
            Assert.AreEqual(expectedSurfaceArea, actualSurfaceArea);
        }

        [DataTestMethod]
        [DataRow(6, 6, 10)]
        [DataRow(12,14,11)]
        public void ConstructorWorksWithMultipleParams(int l, int w, int h)
        {
            //Act
            Room room = new Room(l,w,h);
            Console.WriteLine(room);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Length must be between 6 and 30 feet.")]
        [DataRow(4, 6, 10)]
        [DataRow(3, 14, 11)]
        public void InvalidConstructor_LengthFails(int l, int w, int h)
        {
            //Act
            Room room = new Room(l, w, h);
        }
    }
}
