using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise4
{
    public class Developer
    {
        private string _devName;

        public string DevName
        {
            get => _devName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Developer name cannot be empty.");
                }
                else
                {
                    _devName = value;
                }
            }
        }

        public List<Course> CourseList { get; set; }

        public decimal RemainingBalance { get; set; } = 100m;

        public Developer(string devName, List<Course> courseList, decimal remainingBalance)
        {
            DevName = devName;
            CourseList = courseList;
            RemainingBalance = remainingBalance;
        }

    }
}
