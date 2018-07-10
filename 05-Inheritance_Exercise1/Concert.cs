using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise1
{
    class Concert : Casual, IEmotion
    {
        public override void CalculateCostPerPerson()
        {
            throw new NotImplementedException();
        }

        public void CheckHappiness()
        {
            throw new NotImplementedException();
        }
    }
}
