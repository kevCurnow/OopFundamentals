using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06_Polymorphism_Exercise3;

namespace _06_Polymorphism_UnitTests_3
{
    [TestClass]
    public class UnitTest1
    {
        private List<Badge> _badgeRepository;

        [TestInitialize]
        public void Arrange()
        {
            _badgeRepository = new List<Badge>
            {
                new BadgeA(FloorAccess.One),
                new BadgeB(FloorAccess.Two),
                new BadgeC(FloorAccess.Three),
                new OldBadge(FloorAccess.None),
                new BadgeC(FloorAccess.Three)
            };

        }
        [TestMethod]
        public void CanCompareLists()
        {
            //Arrange
            var expectedList = new List<Badge>
            {
                new BadgeA(FloorAccess.One),
                new BadgeB(FloorAccess.Two),
                new BadgeC(FloorAccess.Three),
                new OldBadge(FloorAccess.None),
                new BadgeC(FloorAccess.Three)
            };

            //Act

            //Assert
            CollectionAssert.AreEqual(expectedList, _badgeRepository);
        }

        [TestMethod]
        public void CanAddBadgeToList_CheckingCount()
        {
            //Arrange
            var newBadge = new BadgeA(FloorAccess.One);

            //Act
            _badgeRepository.Add(newBadge);
            int expectedCount = 6;

            //Assert
            Assert.AreEqual(expectedCount, _badgeRepository.Count);
        }

        [TestMethod]
        public void CanCheckFloorAccess()
        {
            //Arrange
            var aBadge = new BadgeA(FloorAccess.One);
            var bBadge = new BadgeB(FloorAccess.Two);
            var cBadge = new BadgeC(FloorAccess.Three);
            var repo = new BadgeRepository();
            repo.AddBadge(aBadge);
            repo.AddBadge(bBadge);
            repo.AddBadge(cBadge);
            
            //Act
            var actualA = repo.AccessFloor(aBadge, FloorAccess.One);
            var actualB = repo.AccessFloor(bBadge, FloorAccess.One);
            var actualC = repo.AccessFloor(cBadge, FloorAccess.Three);

            //Assert
            Assert.IsTrue(actualA);
            Assert.IsFalse(actualB);
            Assert.IsTrue(actualC);
        }

    }
}
