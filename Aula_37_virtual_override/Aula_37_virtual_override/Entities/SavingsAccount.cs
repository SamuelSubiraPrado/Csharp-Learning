using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_37_virtual_override_sealed.Entities
{
    //SEALED impede que uma outra classe herde dessa classe
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(double interestRate, int number, string holder, double balance) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //SOBRESCEVENDO MÉTODO, também posso selar(SEALED) um
        //método que já foi sobreposto, para que ninguém o reinplemente
        public sealed override void Withdraw(double amount)
        {
            //Posso aproveitar o código já escrito
            base.Withdraw(amount);
            //e fazer novas mudanças depois
            Balance -= 2.0;
        }
    }
}
