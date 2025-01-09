using System;
using System.Globalization;

namespace aula_11_membros_estaticos_sem_classe
{

    class Program
    {
        //Para chamar um método ou usar uma variavel de fora
        //de uma função static, o método ou variavel também
        //deve ser static
        static double Pi = 3.14; // Constante

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        //Membros estaticos, membros de classe, fazem
        //sentido independente de objetos, são chamados 
        //apartir do próprio nome da classe
        static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
                        //Função para elevar o número
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
