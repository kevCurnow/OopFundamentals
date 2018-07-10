using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_Inheritance_Exercise3;

namespace _05_Inheritance_UnitTests_3
{
    [TestClass]
    public class UnitTest1
    {
        private JuniorFrontEnd _juniorFrontEnd;
        private SeniorFrontEnd _seniorFrontEnd;
        private JuniorFrontEnd _juniorFrontEnd2;
        

        [TestInitialize]
        public void Arrange()
        {
            var reduxskills = new List<Enum>();
            reduxskills.Add(ReduxBasics.Eight);
            reduxskills.Add(ReduxForms.Five);
            reduxskills.Add(ReduxSaga.Six);

            var list = new List<Developer>
            {
                _juniorFrontEnd,
                _juniorFrontEnd2,
                _seniorFrontEnd
            };

            var app1 = new App("ElevenNote", AppStatus.WorkingOn, list);
            var appList = new List<App>();
            appList.Add(app1);
            _juniorFrontEnd = new JuniorFrontEnd(4, appList, true, Language.Redux, reduxskills, new DateTime(2018, 5, 5), true);
            _juniorFrontEnd2 = new JuniorFrontEnd(4, appList, true, Language.Redux, reduxskills, new DateTime(2018, 6, 20), true);
            _seniorFrontEnd = new SeniorFrontEnd(6, appList, true, Language.Redux, reduxskills, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "You are lying! You haven't gone through all three weeks of training!")]
        public void CheckValidityOfTraining()
        {
            _juniorFrontEnd2.CheckTraining(new DateTime(2018, 6, 20));
        }

        [TestMethod]
        public void CanAddNewDev()
        {
            Arrange();
            var newDev = new SeniorFrontEnd(6, appList, true, Language.Redux, reduxskills, true);
        }
    }
}
