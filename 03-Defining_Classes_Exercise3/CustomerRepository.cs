using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise3
{
    public class CustomerRepository
    {
        private List<Customer> _customerRepository;

        public CustomerRepository()
        {
            _customerRepository = new List<Customer>();
        }

        public void AddCustomerToList(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public string EmailCustomer(Customer customer)
        {
            var message = "";

            if (customer.YearsWithKomodo > 1 && customer.YearsWithKomodo < 5)
                message = "Thanks for your support";
            else if (customer.YearsWithKomodo >= 5)
                message = "You're a beast.";

            return message;
        }
    }
}
