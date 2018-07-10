using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise3
{
    public enum FloorAccess
    {
        None,
        One, 
        Two,
        Three
    }
    public abstract class Badge
    {
        public FloorAccess FloorAccess { get; set; }

        public Badge()
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            var badge = obj as Badge;
            return badge != null && Equals(badge);
        }

        protected bool Equals(Badge badge)
            => FloorAccess.Equals(badge.FloorAccess);

    }
}
