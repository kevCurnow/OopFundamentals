using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise_4;

namespace _03_Defining_Classes_UnitTests_4
{
    [TestClass]
    public class UnitTest1
    {
        private SalesMember _salesMember;
        private SalesMember _salesMember2;
        private SalesMemberRepository _salesMemberRepository;

        [TestInitialize]
        public void Arrange()
        {
            _salesMember = new SalesMember("Smith", 123.41m);
            _salesMember2 = new SalesMember("Johnson", 456.62m);
            _salesMemberRepository = new SalesMemberRepository();
        }
        [TestMethod]
        public void CombinedTotalSales_ReturnDecimal()
        {
            //Act
            _salesMemberRepository.AddSalesMemberToList(_salesMember);
            _salesMemberRepository.AddSalesMemberToList(_salesMember2);

            var expected = 580.03m;
            var actual = _salesMemberRepository.GetTotalMonthlySales();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
