using System;

namespace Aula_19_modificador_param
{
    internal class Calculator
    {
        //colocar params na frente do vetor, simplifica na chamada do método
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        //REF = permite que a função altere o valor
        //da variavel no escopo original
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
