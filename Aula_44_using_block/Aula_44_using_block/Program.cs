using System;

namespace Aula_44_using_block
{
    class Program
    {
        static void Main(string[] args)
        {
            //using block garante que os objetos sejam fechados de forma simplificada

            string path = @"C:\Windows\Temp\test1.txt";

            try
            {
                //Ao final desse bloco, o recurso instanciado será fechado automaticamente
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    //Posso encadear usings
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
