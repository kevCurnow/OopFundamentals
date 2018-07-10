using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_Exercise_3
{
    public class YoungDrivers
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            private set
            {
                if (value < 16 || value > 25)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 16 and 25");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private const double BASEMONTHLYFEE = 120;

        public YoungDrivers(int age)
        {
            Age = age;
            MonthlyInsuranceRate = age;
        }

        private double _monthlyInsuranceRate;

        public double MonthlyInsuranceRate
        {
            get => _monthlyInsuranceRate;
            private set
            {
                if (Age >= 16 && Age <= 19)
                {
                    value = BASEMONTHLYFEE * 1.9;
                    _monthlyInsuranceRate = value;
                }
                else if (Age >= 20 && Age <= 22)
                {
                    value = BASEMONTHLYFEE * 1.6;
                    _monthlyInsuranceRate = value;
                }
                else if (Age >= 23 && Age <= 25)
                {
                    value = BASEMONTHLYFEE * 1.5;
                    _monthlyInsuranceRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be between 16 and 25");
                }
            }
        }
        //public double CalculateRate(YoungDrivers youngDrivers)
        //{
        //    double rate = 0;
        //    if (youngDrivers.Age >= 16 && youngDrivers.Age <= 19)
        //    {
        //        rate = BASEMONTHLYFEE * 1.9;
        //    }
        //    else if (youngDrivers.Age >= 20 && youngDrivers.Age <= 22)
        //    {
        //        rate = BASEMONTHLYFEE * 1.6;
        //    }
        //    else if (youngDrivers.Age >= 23 && youngDrivers.Age <= 25)
        //    {
        //        rate = BASEMONTHLYFEE * 1.5;
        //    }
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException("Age must be between 16 and 25");
        //    }

        //    return rate;
        //}
    }
}
