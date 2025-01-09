using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29_Operacoes_Com_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AULA DIVIDIDA EM FORMATAÇÃO, PROPRIEDADES E OPERAÇÕES

            //FORMATAÇÃO
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            Console.WriteLine(d.ToLongDateString());//Imprime uma string com o dia por escrito
            Console.WriteLine(d.ToLongTimeString());//Imprime uma string com o horário por escrito
            Console.WriteLine(d.ToShortDateString());//Imprime uma string com o dia resumido
            Console.WriteLine(d.ToShortTimeString());//Imprime uma string com hora e minuto
            Console.WriteLine(d.ToString());//Imprime uma string com hora e minuto

            //Mascara de formatação
            string s1 = d.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s1);

            string s2 = d.ToString("yyyy-MM-dd HH:mm:ss.ffff");
            Console.WriteLine(s2);


            //PROPRIEDADES
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            //OPERAÇÕES
            //Add suports Hours, Minutes, Milisseconds, Months
            //            Seconds, Ticks, Years, Days
            DateTime d2 = d.AddHours(2);
            Console.WriteLine(d);
            Console.WriteLine(d2);

            //Subtract - returns duration
            TimeSpan t = d2.Subtract(d); //Diferença entre d2 e d
            Console.WriteLine(t);



            Console.ReadLine();
        }
    }
}
