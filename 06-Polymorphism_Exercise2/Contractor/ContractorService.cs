using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise2
{
    class ContractorService : IContractorService
    {
        public bool Create(Contractor contractor)
        {
            throw new NotImplementedException();
        }

        public Contractor GetById(int contractorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contractor> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Contractor contractor)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int contractorId)
        {
            throw new NotImplementedException();
        }
    }
}
