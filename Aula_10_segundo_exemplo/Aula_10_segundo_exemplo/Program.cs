using System;
using System.Globalization;

namespace Aula_10_segundo_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Nós mudamos o método ToString para mostrar uma
            //mensagem padrão para quando p for printado (Ver na classe)
            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

        }
    }
}