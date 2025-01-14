﻿using System;

namespace Aula_40_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error!", e.Message);
            }
            finally
            {
                //Geralmente usado pra fechar um arquivo ou
                //Conexão com um banco, SEMPRE VAI SER EXECUTADO
            }
        }
    }
}