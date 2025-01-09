using System;

namespace Aula_2_tipos_split
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implicita
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //Double tem 8 bytes, float tem 4, logo não dá 
            //para converter implicitamente, então temos que
            //fazer casting(que é uma conversão explicita),
            //com isso você está arriscando por conta
            //própria fazer a conversão
            double a = 5.1;
            float b = (float)a;

            //Casting também, porém haverá perca de informação
            //o int irá pegar apenas a parte inteira
            double c = 5.1;
            int d = (int)a;

            //a divisão por padrão irá fazer uma div inteira
            //excluindo a parte flutuante
            int n1 = 5;
            int n2 = 2;
            //O resultado será 2, sendo que deveria ser 2.5
            double resultado = a / b;

            //PARA CORRIGIR ISSO, TEMOS QUE FAZER UM CASTING
            resultado = (double) a / b;

            //para não ter que fazer isso, indicamos que um deles é double
            //por ex: 10.0/5 ou simplesmente def uma das var como double

            //SPLIT
            //declarar uma variavel do tipo string como vetor
       
            string[] vet = Console.ReadLine().Split(' '); //Digitar mais de um valor
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine($"{p1} e {p2} e {p3}.");


        }
    }
}