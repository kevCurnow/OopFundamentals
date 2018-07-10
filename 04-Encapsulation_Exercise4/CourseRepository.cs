using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise4
{
    public class CourseRepository
    {
        private List<Course> _courseRepository;

        public CourseRepository()
        {
            _courseRepository = new List<Course>();
        }


        public void AddCourseToRepository(Course course)
        {
            _courseRepository.Add(course);
        }

        public int GetListCount()
        {
            return _courseRepository.Count();
        }

    }
}
