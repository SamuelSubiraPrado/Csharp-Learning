using System.Drawing;
using System.Globalization;
using System.Net;
namespace Course
{
    class Produto
    {

        //PROPERTIES: Uma propriedade é um membro que oferece um mecanismo flexível para ler,
        //gravar ou calcular o valor de um campo particular.As propriedades podem ser
        //usadas como se fossem atributos públicos, mas na verdade elas são métodos
        //especiais chamados "acessadores". Isso permite que os dados sejam
        //acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
        //dos métodos.

        private string _nome;
        private double _preco;
        private int _quantidade;
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //PROPERTIE, Atribui get e set de uma vez
        public string Nome
        {
            get 
            { 
                return _nome; 
            }

            set 
            {
                //value seria equivalente ao self do py
                //é o argumento que é recebido
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        //PROPERTIE
        public double Preco
        {
            get { return _preco; }
        }

        //PROPERTIE
        public int Quantidade
        {
            get { return _quantidade; }
        }

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