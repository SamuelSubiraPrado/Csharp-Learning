using System;
using System.IO;
//O directory retorn um tipo collection, e para isso temos que importar 
using System.Collections.Generic;

namespace Aula_45_directory_directoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fornecem oferações com pastas e listar diretorios/arquivos
            string path = @"C:\Windows\Temp\myfolder";

            try
            {
                //Listar todas as subpastas apartir da pasta myfolders
                //Args: caminho, padrão de busca, opção de busca
                // *.* = Qualquer nome de arquivo .(ponto) qualquer extensão
                //IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //ou
                var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");

                foreach (string item in folders)
                {
                    Console.WriteLine(item);
                }

                //Listar todos os arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");

                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                //Criar uma pasta
                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}