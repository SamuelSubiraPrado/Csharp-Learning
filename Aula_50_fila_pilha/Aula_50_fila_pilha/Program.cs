using System;

namespace Aula_50_fila_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //FILA - FIFO (First in, first out, quem é adicionado primeiro é o primeiro a sair)
            Queue<string> fila = new Queue<string> ();
            //Enfileirar
            fila.Enqueue("Guilherme");
            fila.Enqueue("Maria");
            fila.Enqueue("João");
            fila.Enqueue("Ana");

            //Remove da fila o primeiro que foi adicionado
            string nomeRemovido = fila.Dequeue();
            Console.WriteLine(nomeRemovido);

            Console.WriteLine();

            //Espiando os elementos
            string nomeEspiado = fila.Peek();
            Console.WriteLine(nomeEspiado);
            Console.WriteLine("---------------------------");
            //-------------------------------------------------------------------

            //PILHA - First in, Last out (O primeiro a entrar, é o ultimo a sair)
            Stack<string> pilha = new Stack<string>(); 
            
            //Adicionando elementos
            pilha.Push("Mariana");
            pilha.Push("Jose");
            pilha.Push("Gabriel");
            pilha.Push("Carlos");

            //Removendo objetos
            string removido = pilha.Pop();
            Console.WriteLine(removido);

            //Espiando os elementos 
            string espiado = pilha.Peek();
            Console.WriteLine(espiado);
            Console.WriteLine("---------------------------");

            //AMBOS POSSUEM OS MESMOS MÉTODOS DAS LITAS (Count, Clear, Concat, Contains, etc)

        }
    }
}
