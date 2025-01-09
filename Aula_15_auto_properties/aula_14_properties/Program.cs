using System;

namespace aula_15_auto_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //Com a propertie, podemos fazer isso, sem ter que
            //chamar o set e usar parenteses
            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            
        }
    }
}