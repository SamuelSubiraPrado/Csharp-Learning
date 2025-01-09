
using System;
using System.Globalization;

namespace Aula12_Construtor_sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());
            p.SetNome("TV 4K");
        }
    }
}