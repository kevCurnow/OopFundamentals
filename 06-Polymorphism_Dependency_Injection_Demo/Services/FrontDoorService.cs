using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Polymorphism_Dependency_Injection_Demo.Contracts;

namespace _06_Polymorphism_Dependency_Injection_Demo.Services
{
    public class FrontDoorService : ISwipeable
    {
        public void Accept()
        {
            throw new NotImplementedException();
        }

        public void Decline()
        {
            throw new NotImplementedException();
        }

        public void Swipe()
        {
            throw new NotImplementedException();
        }
    }
}
