namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount account = new BankAccount("55525" , "Kevin Daouk");   //Uppgift 2
            account.Balance = 1000;

            Console.WriteLine("Kortinnehavare: " + account.AccountHolder + "\nkortnummer: " + account.AccountNumber);
            Console.WriteLine("Saldo: " + account.Balance + "kr");
            account.Deposit(500); Console.WriteLine("Insättning: 500kr" );
            Console.WriteLine("Nytt saldo: " + account.Balance + "kr");
            account.Withdraw(600); Console.WriteLine("Uttag: 600kr");
            Console.WriteLine("Nytt saldo: " + account.Balance + "kr");
            account.Withdraw(1000);
            account.DisplayBalance(account.Balance);



            
            Employee employee = new Employee("Kevin", "Daouk"); //Uppgift 1 
            employee.Salary = 60000;
            Console.WriteLine("");
            Console.WriteLine("Annual salary: " + employee.GetAnnualSalary() + " SEK.");
            employee.GiveRaise(10);
            Console.WriteLine("New monthly salary: " + employee.Salary + " SEK.");
            Console.WriteLine("New annual salary: " + employee.GetAnnualSalary() + " SEK.");


            Console.WriteLine("");
            Employee2 employee2 = new Employee2("Richard");
            employee2.Salary = 30000;
            employee2.Age = 29;
            employee2.DisplayEmployeeInfo();

        }
    }
}
