using Aula_36_upcasting_downcasting.Entities;
using System;

namespace Aula_36_upcasting_downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount acc2 = new BusinessAccount(500, 1002, "Maria", 0.0);

            //UPCASTING - Conversão da subclass para superclass
            Account acc3 = acc2;
            Account acc4 = new BusinessAccount(500, 1003, "Bob", 0.0);
            Account acc5 = new SavingsAccount(600, 1004, "Ana", 0.0);

            //DOWNCASTING - Conversão da superclass para subclass
            BusinessAccount acc6 = (BusinessAccount)acc4;
            acc6.Loan(100.0);

            //Testar se é instancia de um objeto
            if (acc5 is BusinessAccount)
            {
                //O if vai falhar, pq o acc5 é SavingsAccount
                BusinessAccount acc7 = (BusinessAccount)acc5;
            }

        }
    }
}

