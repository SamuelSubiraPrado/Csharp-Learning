using System.Globalization;
namespace Aula12_Construtor_sobrecarga
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto()
        {
        }

        //MÉTODO CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //SOBRECARGA DO CONSTRUTOR
        public Produto(string nome, double preco) : this() //this() reaproveita o construtor base, então tudo que foi feito lá, será herdado aqui
        {
            _nome = nome;
            _preco = preco;
            //Quantidade = 0; já acontece por padrão
        }

        //METODOS GET SETT (ENCAPSULAMENTO)
        public string GetNome() { return _nome; }

        public void SetNome(string nome) 
        {
            //Só vou atribuir o nome se ele for nulo e 
            //o tamanho foi maior que 1
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        //Só faremos o get para preco e quantiadade, para
        // que só seja possível alterar os valores com os
        //metodos adicionar
        public double GetPreco() { return _preco; }
        public int GetQuantidade() { return _quantidade; }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}





