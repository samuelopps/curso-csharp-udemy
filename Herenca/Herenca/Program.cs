using Herenca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Samuel", 500.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Sam", 0.0, 500);

            //UPCASTING - conversao da subclasse em superclasse
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Sam3", 0.0, 500);
            Account account3 = new SavingsAccount(1004, "Sam5", 500.0, 0.01);

            //DOWNCASTING - conversao da superclasse em subclasse

            BusinessAccount account4 = (BusinessAccount)account1;
            account4.Loan(100.0);

            if(account2 is SavingsAccount)
            {
                SavingsAccount account5 = account2 as SavingsAccount;
                Console.WriteLine("Loan");
            }


            //SOBREPOSICAO
            account.WithDraw(10.0);
            account3.WithDraw(10.0);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account3.Balance);

            Console.ReadLine();

        }
    }
}