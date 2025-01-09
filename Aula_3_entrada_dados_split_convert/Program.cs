using System;
using System.Globalization;

namespace Aula3_entrada_dados_split_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convertendo string para int
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(n1);

            //char ch = char.Parse(Console.ReadLine());
            //Console.WriteLine(ch);

            //Para ele salvar corretamente, tem que usar virgula (no BR)
            //caos queira usar com ponto, tem que fazer aquele processo da aula 1
            // com o globalization
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(n2);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}