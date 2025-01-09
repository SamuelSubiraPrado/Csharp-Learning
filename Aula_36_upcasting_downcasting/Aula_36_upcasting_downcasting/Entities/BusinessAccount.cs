namespace Aula_36_upcasting_downcasting.Entities
{
    //Herança
    internal class BusinessAccount : Account
    {
        public double LoanLimit {  get; set; }
        public BusinessAccount() { }

        //Aproveitando o construtor do Account usando o base()
        public BusinessAccount(double loanLimit, int number, string holder, double balance) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
