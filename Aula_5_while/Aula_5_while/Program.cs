using System;
using System.Globalization;

namespace Aula_5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um número (Para parar o programa, envie um n neg): ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine();
                Console.WriteLine("A raiz do número é: " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo");
    
        }
    }
}