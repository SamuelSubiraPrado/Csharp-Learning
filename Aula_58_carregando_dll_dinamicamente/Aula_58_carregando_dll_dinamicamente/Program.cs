using System;

//Temos que adicionar esse namespace
using System.Reflection;

namespace Aula_58_carregando_dll_dinamicamente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carregar o dll 
            Assembly minhaDll = Assembly.LoadFile(@"C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_57_carregando_dlls\Aula_57_carregando_dlls\bin\Debug\Aula_57_carregando_dlls.dll");

            //Carregar a classe que queremos usar   (Namespace.NomeDaClasse)
            Type classeMatematica = minhaDll.GetType("Aula_57_carregando_dlls.Matematica");
        
            //Criando uma instancia de um dll
            dynamic instanciaMatematica = Activator.CreateInstance(classeMatematica);

            //Pegando um metodo
            var metodoSoma = classeMatematica.GetMethod("Soma");

            //Executando o metodo
            double resultado = metodoSoma.Invoke(instanciaMatematica, new object[] {10,20});

            Console.WriteLine(resultado);
        }
    }
}