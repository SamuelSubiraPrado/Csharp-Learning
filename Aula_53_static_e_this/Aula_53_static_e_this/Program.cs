using System;

namespace Aula_53_static_e_this
{
    class Program
    {
        //Modificador static - é usado após o modif de acesso
        //Pode ser usado em: Atributo, propriedade, metodo, struct, classe, etc

        public class Calculadora
        {
            public static double PI = 3.1415;
            public static double CalculaAreaCircunferencia(double pRaio)
            {
                return PI * Math.Pow(pRaio, 2);
            }
        }
        //Não possui nada estático
        public class Pessoa
        {
            private string nome;
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public Pessoa(string pNome)
            {
                nome = pNome;
            }

            public void ImprimeNome()
            {
                Console.WriteLine("O nome é: " + nome);
            }
        }

        public class MinhaPessoa
        {
            private string nome;
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public MinhaPessoa(string nome)
            {
                //Deixamos explicito que isso pertence a classe usando o this
                this.nome = nome;
            }

            public void ImprimeNome()
            {
                Console.WriteLine("O nome é: " + nome);
            }
        }
        static void Main(string[] args)
        {
            //Quando não temos o mod static, o conteudo pertencera ao objeto
            Pessoa pessoa1 = new Pessoa("João");
            Pessoa pessoa2 = new Pessoa("Pedro");
            pessoa1.ImprimeNome();

            //O static pertence a classe, e só pode ser acessado pela classe,
            //nem mesmo as instancias da classe podem usa-los.
            Console.WriteLine("Valor de PI = " + Calculadora.PI);

        }
    }
}