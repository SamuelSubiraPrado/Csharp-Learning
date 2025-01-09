using System;
using System.Globalization;
using Aula_39_classes_abstratas.Entities;

namespace Aula_39_classes_abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesmo sendo abstrata, podemos usar a classe para tipar a lista
           List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        
            foreach (Account account in list)
            {
                account.Withdraw(10.0);
                Console.WriteLine("Update balance for account "
                    + account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}