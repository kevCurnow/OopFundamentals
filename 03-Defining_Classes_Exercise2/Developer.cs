using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise2
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string LastName { get; set; }
        public bool HasPluralsight { get; set; }

        public Developer()
        {
                
        }

        public Developer(int developerId, string lastName, bool hasPluralsight)
        {
            DeveloperId = developerId;
            LastName = lastName;
            HasPluralsight = hasPluralsight;
        }

        public override string ToString()
        {
            return $"{DeveloperId}-{LastName}-{HasPluralsight}";
        }
    }
}
