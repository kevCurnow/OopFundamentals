using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Challenge
{
    public class Program
    {
        public enum Vehicle
        {
            Car = 1,
            Boat,
            Motorcycle,
            Plane
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"How old are you {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

            string AgeBracket;
            if (age >= 18 && age < 27)
            {
                AgeBracket = "Young";
            }
            else if (age >= 27 && age < 65)
            {
                AgeBracket = "Middle";
            }
            else if (age >= 65)
            {
                AgeBracket = "Old";
            }
            else
                throw new ArgumentOutOfRangeException("Too young!");

            Console.WriteLine("What kind of vehicle will you be driving? 1: Car, 2: Boat, 3: Motorcycle, 4: Plane");
            var vehicle = Convert.ToInt32(Console.ReadLine());
            Vehicle vehicleChoice = (Vehicle)vehicle;

            decimal monthlyInsurance = 0m;
            switch (vehicleChoice)
            {
                case Vehicle.Car:
                    switch (AgeBracket)
                    {
                        case "Young":
                            monthlyInsurance = 150m;
                            break;
                        case "Middle":
                            monthlyInsurance = 50m;
                            break;
                        case "Old":
                            monthlyInsurance = 100m;
                            break;
                    }

                    break;
                case Vehicle.Boat:
                    switch (AgeBracket)
                    {
                        case "Young":
                            monthlyInsurance = 200m;
                            break;
                        case "Middle":
                            monthlyInsurance = 100m;
                            break;
                        case "Old":
                            monthlyInsurance = 150m;
                            break;
                    }

                    break;
                case Vehicle.Motorcycle:
                    switch (AgeBracket)
                    {
                        case "Young":
                            monthlyInsurance = 200m;
                            break;
                        case "Middle":
                            monthlyInsurance = 100m;
                            break;
                        case "Old":
                            monthlyInsurance = 250m;
                            break;
                    }

                    break;
                case Vehicle.Plane:
                    switch (AgeBracket)
                    {
                        case "Young":
                            monthlyInsurance = 1000m;
                            break;
                        case "Middle":
                            monthlyInsurance = 500m;
                            break;
                        case "Old":
                            monthlyInsurance = 1000m;
                            break;
                    }

                    break;
                default:
                    throw new ArgumentException("Invalid input");
            }
            Console.WriteLine($"Your monthly insurance rate is ${monthlyInsurance}");
            Console.ReadLine();

        }
    }
}
