using System.Drawing;
using System.Globalization;
using System.Net;

namespace aula_15_auto_properties
{
    class Produto
    {

        //PROPERTIES: Uma propriedade é um membro que oferece um mecanismo flexível para ler,
        //gravar ou calcular o valor de um campo particular.As propriedades podem ser
        //usadas como se fossem atributos públicos, mas na verdade elas são métodos
        //especiais chamados "acessadores". Isso permite que os dados sejam
        //acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
        //dos métodos.


        //Vamos deixar o nome com uma propertie manual, pois 
        //ele tem uma lógica envolvida em sua definição
        private string _nome;
        //AUTO PROPERTIE
        public double Preco { get; private set; }
        //AUTO PROPERTIE
        private int Quantidade {  get; set; } 
        
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}