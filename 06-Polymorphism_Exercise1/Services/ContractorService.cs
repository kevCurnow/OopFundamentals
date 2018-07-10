using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise1
{
    public class ContractorService : IPerson<Contractor>
    {
        public bool Create(Contractor model)
        {
            model.ContractorID = 1;
            return true;
        }

        public Contractor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contractor> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Contractor model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
