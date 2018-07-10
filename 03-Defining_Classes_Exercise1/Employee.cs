using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise1
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumberOfYears { get; set; }

        public Employee(int employeeId, string lastName, int age, int numberOfYears)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            Age = age;
            NumberOfYears = numberOfYears;
        }

        public Employee()
        { }

    }
}
