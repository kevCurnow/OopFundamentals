using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise3
{
    public class SeniorFrontEnd : Senior
    {
        public bool HasCompletedMiniLessons { get; set; }
        public SeniorFrontEnd(int monthlyPluralSightHours, List<App> appsWorkedOn, bool hasCompletedOrientation, Language language, List<Enum> skillSet, bool hasCompletedMiniLessons) : base(monthlyPluralSightHours, appsWorkedOn, hasCompletedOrientation, language, skillSet)
        {
            HasCompletedMiniLessons = hasCompletedMiniLessons;
        }
    }
}
