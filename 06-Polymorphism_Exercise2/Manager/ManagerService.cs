using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise2
{
    class ManagerService : IManagerService
    {
        public bool Create(Manager manager)
        {
            throw new NotImplementedException();
        }

        public Manager GetById(int managerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manager> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Manager manager)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int managerId)
        {
            throw new NotImplementedException();
        }
    }
}
