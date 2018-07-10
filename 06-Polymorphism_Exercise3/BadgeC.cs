using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise3
{
    public class BadgeC : Badge
    {
        public BadgeC(FloorAccess floorAccess)
        {
            floorAccess = FloorAccess.Three;
        }
    }
}
