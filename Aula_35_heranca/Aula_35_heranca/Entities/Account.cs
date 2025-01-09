﻿namespace Aula_35_heranca.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }

        //Protected fará com que as subclasses tenham acesso
        //a alterar a variavel
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}