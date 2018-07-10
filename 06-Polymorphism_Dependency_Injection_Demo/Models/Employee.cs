using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using _06_Polymorphism_Dependency_Injection_Demo.Contracts;

namespace _06_Polymorphism_Dependency_Injection_Demo.Models
{
    public class Employee
    {
        private ISwipeable _swipeable;

        public Employee(ISwipeable swipeable)
        {
            _swipeable = swipeable;
        }

        public void SwipeCard()
        {
            Console.WriteLine("Swiping card now");
            _swipeable.Swipe();
        }
    }
}
