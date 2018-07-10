using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise3
{
    public class OldBadge : Badge
    {
        public OldBadge(FloorAccess floorAccess) : base(floorAccess)
        {
            floorAccess = FloorAccess.None;
        }
    }
}
