using System;
using System.Globalization;

namespace Aula_18_vetores_problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas alturas deseja salvar:");
            int n = int.Parse(Console.ReadLine());

            //Vetor: tipo[] nomeVar = new tipo[quantidade]
            double[] vect = new double[n];

            Console.WriteLine("Digite as alturas:");
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.00;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i]; 
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}