using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise5
{
    public class ClaimRepository
    {
        public bool IsClaimValid(InsuranceClaim claim)
        {
            if ((DateTime.Now - claim.DateOfIncident).Days < 30)
            {
                return true;
            }

            return false;
        }

        public string ProcessClaim(InsuranceClaim claim)
        {
            if (claim.ClaimAmount > 10000)
            {
              return "Please call your agent.";
            }

            return "Your claim is being processed.";
        }

    }
}
