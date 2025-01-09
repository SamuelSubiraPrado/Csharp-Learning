using System;

namespace Aula_22_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de dado[,virgula] variavel = new tipo de dado[quantas linhas e colunas você quer]
            double[,] mat = new double[2,3]; //2 linhas e 3 colunas.
            Console.WriteLine(mat.Length); //tamanho da mat
            Console.WriteLine(mat.Rank); //quantidade de linhas
            Console.WriteLine(mat.GetLength(0));//qual o tamanho da primeira definição? nesse caso, o número de linhas
            Console.WriteLine(mat.GetLength(1));//numero de colunas
        }
    }
}