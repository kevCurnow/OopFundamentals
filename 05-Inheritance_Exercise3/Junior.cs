using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise3
{
    public class Junior : Developer
    {
        public Junior(int monthlyPluralSightHours, List<App> appsWorkedOn,
            bool hasCompletedOrientation, Language language, List<Enum> skillSet)
        {
            MonthlyPluralSightHours = monthlyPluralSightHours;
            AppsWorkedOn = appsWorkedOn;
            HasCompletedOrientation = hasCompletedOrientation;
            Language = language;
            SkillSet = skillSet;
        }
    }
}
