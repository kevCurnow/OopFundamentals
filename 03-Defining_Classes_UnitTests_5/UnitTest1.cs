using System;
using System.Security.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_Defining_Classes_Exercise5;

namespace _03_Defining_Classes_UnitTests_5
{
    [TestClass]
    public class UnitTest1
    {
        private InsuranceClaim _claimInvalid;
        private InsuranceClaim _claimOver;
        private InsuranceClaim _claimUnder;
        private ClaimRepository _claimRepository;

        [TestInitialize]
        public void Arrange()
        {
            _claimInvalid = new InsuranceClaim(DateTime.Parse("2018, 05, 02"), 12300);
            _claimOver = new InsuranceClaim(DateTime.Parse("2018, 06, 29"), 12300);
            _claimUnder = new InsuranceClaim(DateTime.Parse("2018, 06, 29"), 2994);
            _claimRepository = new ClaimRepository();
        }

        [TestMethod]
        public void CanTestValidityofClaims()
        {
            //Act
            var actualInvalid = _claimRepository.IsClaimValid(_claimInvalid);
            var actualOver = _claimRepository.IsClaimValid(_claimOver);
            var actualUnder = _claimRepository.IsClaimValid(_claimUnder);
            Console.WriteLine($"{actualInvalid}-{actualOver}-{actualUnder}");

            var expectedInvalid = false;
            var expectedOver = true;
            var expectedUnder = true;

            //Assert
            Assert.AreEqual(expectedInvalid, actualInvalid);
            Assert.AreEqual(expectedOver, actualOver);
            Assert.AreEqual(expectedUnder, actualUnder);
        }

        [TestMethod]
        public void CanSendProperMessage()
        {
            //Act
            var actualInvalid = _claimRepository.ProcessClaim(_claimInvalid);
            var actualOver = _claimRepository.ProcessClaim(_claimOver);
            var actualUnder = _claimRepository.ProcessClaim(_claimUnder);
            Console.WriteLine($"{actualInvalid}-{actualOver}-{actualUnder}");

            var expectedInvalid = "Please call your agent.";
            var expectedOver = "Please call your agent.";
            var expectedUnder = "Your claim is being processed.";

            //Assert
            Assert.AreEqual(expectedInvalid, actualInvalid);
            Assert.AreEqual(expectedOver, actualOver);
            Assert.AreEqual(expectedUnder, actualUnder);
        }
    }
}
