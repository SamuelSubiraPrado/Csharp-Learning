using System;
//----------------------------
using Aula_57_carregando_dlls;

namespace Aula_57_carregando_dlls_parte_do_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos carregar a dll do arquivo anterior aula57
            //No menu de soluções                     -------------------------------->
            //Selecionar Dependencies, Add project Referencie, Browse,
            //selecionar pasta com o executavel do dll e colocar using ____(namespace da dll)

            Console.WriteLine(Matematica.Soma(5,6));
            Console.WriteLine(Matematica.Multiplica(7,8));
        }
    }
}