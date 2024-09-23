using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string  accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        //Lägg till Metoder
        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
            }
        }
        
        public void Withdraw(double amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Du kan ej ta ut " + amount + "kr, saldot räcker inte till.");
            }
        }
        
        public void DisplayBalance(double balance)
        {
            Console.WriteLine("Det aktuella saldot är: " + Balance + "kr");
        }

        //Lycka till! :)
    }
}
