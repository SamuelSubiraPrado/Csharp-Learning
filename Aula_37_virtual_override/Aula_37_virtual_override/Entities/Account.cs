namespace Aula_37_virtual_override_sealed.Entities
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

        //MÉTODO A SER SOBRESCRITO
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
