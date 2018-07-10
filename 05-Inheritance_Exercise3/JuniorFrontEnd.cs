using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise3
{
    public class JuniorFrontEnd : Junior
    {
        public DateTime TrainingStart { get; set; }
        public bool HasCompletedTraining { get; set; }
        public JuniorFrontEnd(int monthlyPluralSightHours, List<App> appsWorkedOn, bool hasCompletedOrientation, Language language, List<Enum> skillSet, DateTime trainingStart, bool hasCompletedTraining) : base(monthlyPluralSightHours, appsWorkedOn, hasCompletedOrientation, language, skillSet)
        {
            TrainingStart = trainingStart;
            HasCompletedTraining = hasCompletedTraining;
        }

        public void CheckTraining(DateTime startTraining)
        {
            TimeSpan TrainingTime = DateTime.Now - startTraining;
            if ((TrainingTime.TotalDays / 7) < 3)
            {
                throw new ArgumentException("You are lying! You haven't gone through all three weeks of training!");
            }
        }

    }
}
