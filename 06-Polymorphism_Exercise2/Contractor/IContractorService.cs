using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise2
{
    interface IContractorService
    {
        bool Create(Contractor contractor);
        Contractor GetById(int contractorId);
        IEnumerable<Contractor> GetAll();
        bool Update(Contractor contractor);
        bool Delete(int contractorId);
    }
}
