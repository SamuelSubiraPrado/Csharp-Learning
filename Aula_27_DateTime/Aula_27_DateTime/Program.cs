using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instante atual do sistema
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            //Quantidade de Ticks que já passaram desde o 
            //começo Da era atual
            Console.WriteLine(d1.Ticks);

            //Temos varias sobrecargas para o construtor
            //1) Passar Ano mes e dia
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            //2) Passar Ano mes e dia e horário(hora, min, seg)
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);
            Console.WriteLine(d3);

            //3) Passar Ano mes e dia e horário(hora, min, seg, milisegundos)
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 99);
            Console.WriteLine(d4);

            //Data de hoje, horário zerado
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            //Horário universal (Greenwitch)
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);

            //Digitar uma data para ser convertida em DateTime
            DateTime d7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d7);

            //Digitar uma data e hora para ser convertida em DateTime
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);

            //Digitar uma data no padrão BR para ser convertida em DateTime
            DateTime d9 = DateTime.Parse("17/08/2000");
            Console.WriteLine(d9);

            //Digitar uma data e hora para ser convertida em DateTime
            DateTime d10 = DateTime.Parse("17/08/2000 13:05:58");
            Console.WriteLine(d10);

            //Quero determinar o formato da minha data
            DateTime d11 = DateTime.ParseExact("17/08/2000", "yyyy/MM/dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

            //Quero determinar o formato da minha data e hora
            DateTime d12 = DateTime.ParseExact("17/08/2000 12:07:09", "yyyy/MM/dd HH:mm:ss" , CultureInfo.InvariantCulture);
            Console.WriteLine(d12);








            Console.ReadLine();
        }
    }
}
