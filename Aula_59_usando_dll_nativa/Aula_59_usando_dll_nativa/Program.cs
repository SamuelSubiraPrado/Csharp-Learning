using System;
//Adicionar isso
using System.Runtime.InteropServices;


namespace Aula_59_usando_dll_nativa
{
    class CascaDLLNativa
    {
        //Caminho da dll
        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        //Indica que a função está externamente
        public static extern double Soma(double a, double b);
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Copiei e colei uma pasta chamada DLL no arquivo fonte
            double resultadoSoma = CascaDLLNativa.Soma(10, 20);
            Console.WriteLine("O resultado da soma de 10 e 20 é: " + resultadoSoma);


        }
    }
}