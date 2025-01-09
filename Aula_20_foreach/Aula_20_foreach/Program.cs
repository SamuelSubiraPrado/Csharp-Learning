using System;

namespace Aula_20_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOREACH é uma sintaxe opcional para percorrer coleções
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

        }
    }
}

