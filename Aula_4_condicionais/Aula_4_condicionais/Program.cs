using System;

namespace Aula_4_condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            if(x < 5){Console.WriteLine("X menor que 5");}
            else if(x == 10){   Console.WriteLine("X igual a 10");}
            else{ Console.WriteLine("X maior que 5 e diferente de 10");}

            Console.WriteLine("Entre com um número inteiro: ");
            
            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}