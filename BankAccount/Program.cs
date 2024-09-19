namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            Employee myEmployee = new Employee("Kevin" , "Daouk" , 60000);

            Console.WriteLine("Your annual salary: " + myEmployee.GetAnnualSalary(60000) + " SEK.");
            
        }
    }
}
