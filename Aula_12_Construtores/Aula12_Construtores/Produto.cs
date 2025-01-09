using System.Globalization;
namespace Aula12_Construtor_sobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        
        public Produto()
        {
            Quantidade = 10;
        }

        //MÉTODO CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //SOBRECARGA DO CONSTRUTOR
        public Produto(string nome, double preco) : this() //this() reaproveita o construtor base, então tudo que foi feito lá, será herdado aqui
        {
            Nome = nome;
            Preco = preco;
            //Quantidade = 0; já acontece por padrão
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}





