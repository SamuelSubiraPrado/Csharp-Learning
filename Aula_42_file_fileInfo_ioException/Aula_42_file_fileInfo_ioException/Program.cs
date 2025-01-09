using System;

//Vai nos permitir trabalhar com arquivos
using System.IO;

namespace Aula_42_file_fileInfo_ioException
{

    //C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_42_file_fileInfo_ioException
    class Program
    {
        static void Main(string[] args)
        {
            //Colocando o Arroba@ não precisamos colocar as barras duplas
            string sourcePath = @"c:\windows\temp\test1.txt";
            string targetPath = @"c:\windows\temp\test2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //Não vamos abordar todas as operação, para isso, pesquisar
                fileInfo.CopyTo(targetPath);
                //Salvando as linhas do arquivo
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
