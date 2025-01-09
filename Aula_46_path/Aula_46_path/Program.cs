using System;
using System.IO;

namespace Aula_46_path
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realiza operações com strings que contém infos de arquivos ou pastas


            string path = @"C:\Windows\Temp\myfolder\file1.txt";

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); //Quem é a pasta temp do meu sistema
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            

        }
    }
}