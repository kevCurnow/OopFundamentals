using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise2
{
    interface IInstructorService
    {
        bool Create(Instructor instructor);
        Instructor GetById(int instructorId);
        IEnumerable<Instructor> GetAll();
        bool Update(Instructor instructor);
        bool Delete(int instructorId);
    }
}
