using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan - representa uma duração na duração de ticks
            
            //Também tem varios construtores
            //Horas, min, seg
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            //Cria com duração 0
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine(t2);

            //Passar com quantidade de ticks, ele converte para h,m,s
            TimeSpan t3 = new TimeSpan(900000000L); //= 1m30s
            Console.WriteLine(t3);

            //Passar com quantidade de Dias, H, M, S
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t4);

            //Passar com quantidade de Dias, H, M, S, MS
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t5);

            //Instanciar usando métodos From (Days,Hours, Minutes,Seconds,Milliseconds,Ticks(L no final))
            TimeSpan t6 = TimeSpan.FromDays(1.5);//equivalente a 1 dia e meio
            Console.WriteLine(t6);

            Console.ReadLine();
        }
    }
}
