using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise2
{
    class InstructorService : IInstructorService
    {
        public bool Create(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public Instructor GetById(int instructorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int instructorId)
        {
            throw new NotImplementedException();
        }
    }
}
