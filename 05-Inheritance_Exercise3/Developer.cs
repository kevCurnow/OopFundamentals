using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise3
{
    public enum Language
    {
        Redux = 1,
        Flux,
        AngularJS,
        Angular6,
        CSharp,
        DotNetCore
    }
public abstract class Developer
    {

        public int MonthlyPluralSightHours { get; set; }
        public List<App> AppsWorkedOn { get; set; }
        //List<App> AppsWorkedOn = new List<App>();
        public bool HasCompletedOrientation { get; set; }

        public Language Language;

        public List<Enum> SkillSet { get; set; }
        //List<Enum> SkillSet = new List<Enum>();

        public Developer()
        {

        }

        public Developer(int monthlyPluralSightHours, List<App> appsWorkedOn,
            bool hasCompletedOrientation, Language language, List<Enum> skillSet)
        {
            MonthlyPluralSightHours = monthlyPluralSightHours;
            AppsWorkedOn = appsWorkedOn;
            HasCompletedOrientation = hasCompletedOrientation;
            Language = language;
            SkillSet = skillSet;
        }

        public void AddAppToList(App app)
        {
            AppsWorkedOn.Add(app);
        }

        public void AddSkillToList(Enum skill)
        {
            SkillSet.Add(skill);
        }
    }
}
