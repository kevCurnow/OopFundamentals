using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise2
{
    public class Team
    {
        private List<Developer> _developers;

        public Team()
        {
            _developers = new List<Developer>();
        }

        public List<Developer> AddDeveloper(Developer dev)
        {
            _developers.Add(dev);
            return _developers;
        }

        public int GetListCount()
        {
            return _developers.Count();
        }
    }

}
