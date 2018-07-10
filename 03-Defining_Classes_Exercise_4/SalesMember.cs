using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class SalesMember
    {
        public string LastName { get; set; }
        public decimal TotalMonthlySales { get; set; }

        public SalesMember(string lastName, decimal totalMonthlySales)
        {
            LastName = lastName;
            TotalMonthlySales = totalMonthlySales;
        }
    }
}
