using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism_Exercise3
{
    public class BadgeRepository
    {
        private List<Badge> _badgeRepository = new List<Badge>();

        public void AddBadge(Badge badge)
        {
            _badgeRepository.Add(badge);
        }

        public List<Badge> ReturnBadgeList()
        {
            return _badgeRepository;
        }

        public bool AccessFloor(Badge badge, FloorAccess floorAccess)
        {
            if (badge.FloorAccess == floorAccess)
                return true;
            return false;
        }
    }
}
