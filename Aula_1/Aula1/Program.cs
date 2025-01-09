using System;
using System.Globalization;

//IDENTAÇÃO AUTOMATICA CTRL + K + D

namespace Aula1 //opcional (mas é boa prática)
{
    class Program //mesmo nome do arquivo
    {
        static void Main(string[] args)
        {
            //tipos
            byte n1 = 126;
            int n2 = 2147483647;
            long n3 = 2147483648;
            bool n4 = true;//ou false;
            char genero = 'F';
            float n5 = 4.5f; //Float tem que colocar f no final
            double n6 = 4.5;
            string nome = "Maria";
            int idade = 18;
            double saldo = 500.99;
            object obj1 = "Alex"; //equivalente ao var
            object obj2 = 4.5;  //se adapta ao tipo do dado

            //Controlar o número de casas decimais
            //que um double/float imprimem na tela, 
            //F2 = 2 casas, F3 = 3 casas, etc
            Console.WriteLine(n5.ToString("F2"));

            //Para mudar a impressão de "," para "."
            //chamamos using System.Globalization;
            //colocamos após a formatação, CultureInfo.InvariantCulture
            Console.WriteLine(n5.ToString("F3", CultureInfo.InvariantCulture));

            //Placeholders, concatenação e interpolação
            
            //Placeholders, colocamos nas chaves, a ordem em que as var vão entrar
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação, colocamos $ antes e colocar chaves e suas variaveis
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação, "" + var + "" ...
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}