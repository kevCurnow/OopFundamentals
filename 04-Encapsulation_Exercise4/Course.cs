using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise4
{
    public class Course
    {
        private string _courseName;

        public string CourseName
        {
            get => _courseName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course name cannot be empty.");
                }
                else
                {
                    _courseName = value;
                }
            }
        }

        private decimal _coursePrice;

        public decimal CoursePrice
        {
            get => _coursePrice;
            set
            {
                if (value > 100m)
                {
                    throw new ArgumentOutOfRangeException("You only have $100 to spend on courses!");
                }
                else
                {
                    _coursePrice = value;
                }
            }
        }

        public Course(string courseName, decimal coursePrice)
        {
            CourseName = courseName;
            CoursePrice = coursePrice;
        }
        
    }
}
