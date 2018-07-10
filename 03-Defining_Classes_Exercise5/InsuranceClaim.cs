using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise5
{
    public class InsuranceClaim
    {
        public DateTime DateOfIncident { get; set; }
        public int ClaimAmount { get; set; }
        
        public InsuranceClaim(DateTime dateOfIncident, int claimAmount)
        {
            DateOfIncident = dateOfIncident;
            ClaimAmount = claimAmount;
        }
    }
}
