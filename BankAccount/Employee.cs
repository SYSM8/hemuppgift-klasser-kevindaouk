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
        public int Salary {  get; set; }

        public Employee(string firstName, string lastName, int salary)
        {
            firstName = firstName;
            lastName = lastName;
            salary = salary;

        }

        public int GetAnnualSalary(int salary)
        {
            int annualSalary = salary * 12;
            
            return annualSalary;
        }

        public double GiveRaise(double percentage)
        {
            double salaryRaise = 0.10 * Salary;
            return salaryRaise;
        }

    }

    
}
