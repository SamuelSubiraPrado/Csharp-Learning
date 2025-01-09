using System;
using System.Globalization;

namespace Aula_25_expressao_cond_ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cond Ternária: Decidir um VALOR com base em uma condição
            //( condição ) ? valor_se_verdadeiro : valor_se_falso

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //Fariamos dessa forma sem a expressão condicional ternaria
            /* double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);*/

            //-------------------------------------------
            //Já com a expressão ternária, ficaria assim:

            //Decidir um VALOR com base em uma condição
            //( condição ) ? valor_se_verdadeiro : valor_se_falso

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }
    }
}
