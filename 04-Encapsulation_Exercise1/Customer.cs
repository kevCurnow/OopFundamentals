using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise1
{
    public class Customer
    {
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty.");
                }
                else
                {
                    _lastName = value;
                }
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("The age is not within the proper range.");
                }
                else
                {
                    _age = value;
                }
            }
        }


        public Customer(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString() =>
            string.Format($"First Name: {_firstName}, Last Name: {_lastName}, Age: {_age}");

    }
}
