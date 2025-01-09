using System;
using System.Globalization;

namespace Aula_10_segundo_exemplo
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int quantidade_adicionar)
        {
            quantidade += quantidade_adicionar;
        }

        public void RemoverProdutos(int quantidade_adicionar)
        {
            quantidade -= quantidade_adicionar;
        }

        //Sobreposição da função ToString que vem da classe
        //base do C#, a classe Object, da qual todo método herda
        public override string ToString()
        {
            return nome 
                + ", $ " 
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " 
                + quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
