using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Salary {  get; set; }

        public Employee(string firstName, string lastName)          //KONSTRUKTOR
        {
            firstName = firstName;
            lastName = lastName;
            
        }

        public double GetAnnualSalary()
        {
            double annualSalary = Salary * 12;
            
            return annualSalary;
        }

        public void GiveRaise(double percentage)
        {
            Salary = Salary * ((percentage /100)+1);
           
        }

    }

    
}
