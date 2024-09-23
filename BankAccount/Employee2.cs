using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Employee2
    {
        public string Name { get; set; }
        private int age;
        private double salary;


        public Employee2(string name)
        {
            Name = name;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Ålder kan ej 0 eller mindre.");
                }
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Lönen måste vara mer än 0.");
                }
            }
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine(Name + ", " + salary + ", " + age);
        }

    }
}
