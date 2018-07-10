using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Inheritance_Exercise1
{
    public abstract class Outing
    {
        public int NumberAttended { get; set; }
        public DateTime OutingDate { get; set; }
        public string Location { get; set; }
        public decimal TotalCost { get; set; }

        public Outing()
        {

        }

        public Outing(int numberAttended, DateTime outingDate, string location, decimal totalCost)
        {
            NumberAttended = numberAttended;
            OutingDate = outingDate;
            Location = location;
            TotalCost = totalCost;
        }

        public abstract void CalculateCostPerPerson();
    }
}
