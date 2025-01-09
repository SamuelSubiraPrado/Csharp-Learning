using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_48_solucao_com_interface.Services
{
    //Indica que é um subtipo da interface ItaxService
    internal class BrazilTaxService : ITaxService
    {
        //Tem que implementar o método da interface
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
