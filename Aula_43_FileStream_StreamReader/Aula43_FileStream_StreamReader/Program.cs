using System;
using System.IO;

namespace Aula43_FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream oferece suporte a dados binários
            //StreamReader é capaz de ler caracteres a partir de uma stream binária

            string path = @"C:\Windows\Temp\test1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //Parametros: Caminho do arquivo, modo do arquivo
                fs = new FileStream(path, FileMode.Open); //Vai abrir o arquivo p/acesso
                sr = new StreamReader(fs);

                //Enquanto não chegar ao final do arquivo
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //TENHO QUE FECHAR OS ARQUIVOS
                //Ser diferente de nulo, significa que o arquivo está aberto
                if (sr != null) { sr.Close(); }
                if (fs != null) { fs.Close(); }
            }
        }
    }
}

