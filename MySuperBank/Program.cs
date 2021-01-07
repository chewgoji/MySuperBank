using System;
using BankyStuffLibary;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 9101010);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hamick");
            account.MakeWithdrawal(3000, DateTime.Now, "Xbox");
            account.MakeWithdrawal(50000, DateTime.Now, "House");
            account.MakeWithdrawal(60, DateTime.Now, "XXX");
            account.MakeWithdrawal(10000, DateTime.Now, "Doctor");
            account.MakeWithdrawal(999999, DateTime.Now, "Box");

            Console.WriteLine(account.GetAccountHistory());            
        }
    }
}
