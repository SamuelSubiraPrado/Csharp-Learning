using System;
using System.Globalization;

namespace Aula_16_tipo_ref_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo valor pode ser só declarado (Também podemos fazer a instancia0
            Point p;
            //E utilizado logo em seguida, sem precisar de construtor
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
        }
    }
}