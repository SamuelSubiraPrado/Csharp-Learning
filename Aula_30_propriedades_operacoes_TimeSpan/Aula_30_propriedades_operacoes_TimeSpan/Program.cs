using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_30_propriedades_operacoes_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROPRIEDADES
            TimeSpan t1 = TimeSpan.MaxValue; //Valor máximo possível de se armazenar num TimeSpan
            TimeSpan t2 = TimeSpan.MinValue; //Valor minimo possível de se armazenar num TimeSpan
            TimeSpan t3 = TimeSpan.Zero;

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            //Retornam double
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            //OPERAÇÕES
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0); //FUNCIONA SÓ CRIANDO COMO CONSOLE
            TimeSpan div = t5.Divide(2.0);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.ReadLine();
        }
    }
}
