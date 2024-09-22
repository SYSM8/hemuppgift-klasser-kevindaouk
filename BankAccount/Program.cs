namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount account = new BankAccount("55525" , "Kevin Daouk");
            account.Balance = 1000;

            Console.WriteLine("Kortinnehavare: " + account.AccountHolder);
            Console.WriteLine("Saldo: " + account.Balance + "kr");
            account.Deposit(500); Console.WriteLine("Insättning: 500kr" );
            Console.WriteLine("Nytt saldo: " + account.Balance + "kr");
            account.Withdraw(600); Console.WriteLine("Uttag: 600kr");
            Console.WriteLine("Nytt saldo: " + account.Balance + "kr");
            account.Withdraw(1000);
            account.DisplayBalance(account.Balance);

            Employee employee = new Employee("Kevin", "Daouk");
            employee.Salary = 60000;
            Console.WriteLine("");
            Console.WriteLine("Annual salary: " + employee.GetAnnualSalary() + " SEK.");
            employee.GiveRaise(10);
            Console.WriteLine("New monthly salary: " + employee.Salary + " SEK.");
            Console.WriteLine("New annual salary: " + employee.GetAnnualSalary() + " SEK.");

        }
    }
}
