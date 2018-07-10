using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise4
{
    public class DeveloperRepository
    {
        private List<Developer> _developerRepository;

        public DeveloperRepository()
        {
            _developerRepository = new List<Developer>();
        }

        public void AddDeveloperToRepository(Developer developer)
        {
            _developerRepository.Add(developer);
        }

        public void AddCourseToList(Course course, Developer developer)
        {
            if (course.CoursePrice <= developer.RemainingBalance)
            {
                developer.CourseList.Add(course);
                developer.RemainingBalance -= course.CoursePrice;
            }
            else
            {
                throw new ArgumentException("You don't have enough money for that course!");
            }
        }
    }
}
