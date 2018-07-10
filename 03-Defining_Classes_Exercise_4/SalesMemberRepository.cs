using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_4
{
    public class SalesMemberRepository
    {
        private List<SalesMember> _salesMemberRepository;

        public SalesMemberRepository()
        {
            _salesMemberRepository = new List<SalesMember>();
        }

        public void AddSalesMemberToList(SalesMember salesMember)
        {
            _salesMemberRepository.Add(salesMember);
        }

        public decimal GetTotalMonthlySales()
        {
            decimal totalSalesForTeam = 0;
            foreach (var s in _salesMemberRepository)
            {
                totalSalesForTeam += s.TotalMonthlySales;
            }

            return totalSalesForTeam;
        }
    }
}
