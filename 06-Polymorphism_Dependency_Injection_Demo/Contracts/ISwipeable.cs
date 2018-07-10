using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Dependency_Injection_Demo.Contracts
{
    public interface ISwipeable
    {
        void Accept();
        void Decline();
        void Swipe();
    }
}
