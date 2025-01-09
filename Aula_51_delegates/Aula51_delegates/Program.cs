using System;

namespace Aula51_delegates
{
    class Program
    {
        //Delegates conseguimos criar uma variavel que guarda um metodo
        //e pode ser executado a qualquer momento, conseguimos usa-los
        //de paramentros para outros metodos
        public delegate double MeuDelegateOperacoes(double a, double b);

        public static double Soma(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} = {resultado}");
            return resultado;
        }

        public static double Multiplicacao(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine($"A Multiplicacao de {a} * {b} = {resultado}");
            return resultado;
        }

        public static double Divisao(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine($"A Divisão de {a} / {b} = {resultado}");
            return resultado;
        }

        static void Main(string[] args)
        {
            MeuDelegateOperacoes minhasOperacoes;
            //Estamos fazendo o Delegate se referenciar ao metodo soma
            minhasOperacoes = Soma;
            double resultadoDelegate = minhasOperacoes(10, 20);
            Console.WriteLine($"O resultado do Delegate é = {resultadoDelegate}");

            //Agora ele se referencia a 3 métodos
            minhasOperacoes += Multiplicacao;
            minhasOperacoes += Divisao;
            Console.WriteLine("-----------------");

            //Todos os métodos serão executados;
            resultadoDelegate = minhasOperacoes(30, 40);

            //Ele retorna apenas o valor do ultimo método referenciado por ele
            Console.WriteLine($"O resultado do Delegate é = {resultadoDelegate}");
        }
    }
}
