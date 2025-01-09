using System;
using System.Collections.Generic;

namespace Aula_21_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //uma lista começa vazia, ela não é padrão C#
            //então precisamos chamar using System.Collections.Generic;
            List<string> list = new List<string>(); //Posso, começar com ela vazia

            //List<string> list2 = new List<string>() {"Maria", "Alex"}; //Também posso criar ela já dando valores

            //é facil de inserir e remover elementos

            //Inserir dados na lista
            //add - adiciona ao final da lista
            list.Add("Amanda");
            list.Add("Maria");
            list.Add("Bob");
            list.Add("Ana");

            //insert - você pode definir a posição
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //Contagem da lista
            Console.WriteLine("List count: " + list.Count);

            //Achar a primeira ocorrencia de um nnome que comece com a
            //função FIND, recebe como argumento uma função que faz um teste ou uma função lambda
            string s1 = list.Find(Test);
            //ou usando lambda
            //string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            
            //               x tal que x na pos 0 seja igual a 'A'
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
        
            //acha o ultimo número do index
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //Filtrar lista, criando uma nova lista com os resultados que satisfazem o filtro
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            //Remover elementos da lista
            //remove - espera uma string como parametro
            list.Remove("Alex");

            //RemoveAll - espera um método/predicado como parametro
            list.RemoveAll(x => x[0] == 'M'); //Todos que começarem com M serão removidos

            //RemoveAt - remove de uma det posição
            list.RemoveAt(3);

            //RemoveRange - remove elementos de uma faixa
            //Apartir da posição x, quero remover x elementos
            list.RemoveRange(2, 2);
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
