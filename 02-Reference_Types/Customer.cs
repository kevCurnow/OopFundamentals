using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reference_Types
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Accidents { get; set; }

        public Customer(string firstName, string email, string phoneNumber, int accidents)
        {
            FirstName = firstName;
            Email = email;
            PhoneNumber = phoneNumber;
            Accidents = accidents;
        }

        public Customer()
        { }

        public void AddAccidents(int NewAccidents)
        {
            Accidents += NewAccidents;
        }
    }
}
