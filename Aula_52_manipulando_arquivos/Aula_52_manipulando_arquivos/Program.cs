using System;
//Tem que importar o System.IO;
using System.IO;


namespace Aula_50_fila_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando caminhos de arquivo
            //1)
            string caminho2 = "C:\\Arquivos Samuel\\Cursos\\C#\\Curso C#\\Aula_52_Teste_Arquivos\\teste.txt";
            //2)
            string caminho = @"C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_52_Teste_Arquivos\teste.txt";


            //Verificando se um arquivo existe
            bool arquivoExiste = File.Exists(caminho);

            if (arquivoExiste)
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                //Criando um arquivo
                FileStream meuArquivo = File.Create(caminho);
                Console.WriteLine("O Arquivo foi criado");
                //TEMOS QUE FECHAR O ARQUIVO!
                meuArquivo.Close();
            }

            //Deletando arquivos
            File.Delete(caminho);
            Console.WriteLine("Arquivo Deletado");

            string caminhoNovo = @"C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_52_Teste_Arquivos\teste3.txt";
            arquivoExiste = File.Exists(caminhoNovo);

            if (arquivoExiste)
            {
                Console.WriteLine("O arquivo existe");
            }
            else
            {
                //Renomenado arquivos
                string caminhoAntigo = @"C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_52_Teste_Arquivos\teste2.txt";
                FileStream meuArquivo2 = File.Create(caminhoAntigo);
                meuArquivo2.Close();

                File.Move(caminhoAntigo, caminhoNovo);
                Console.WriteLine("Arquivo Renomeado");
            }

            //Escrevendo em um arquivo de texto
            string conteudo = "Marcos é um cara legal \r\n Pulei a linha \r\n Pedro é inteligente";
            File.WriteAllText(caminhoNovo,conteudo);


            string caminho5 = @"C:\Arquivos Samuel\Cursos\C#\Curso C#\Aula_52_Teste_Arquivos\teste4.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            //Escrevendo um array de strings
            string[] conteudoArray = { "Guilherme", "Marcos", "Pedro" };
            File.WriteAllLines(caminho5, conteudoArray);

            //Lendo o conteudo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);

            //Lendo o conteudo de um arquivo e gravando num array de strings
            string[] conteudoLidoArray = File.ReadAllLines(caminho5);
            foreach (string str in conteudoArray) { Console.WriteLine(str); }

            //Acrescentar novos textos a um arquivo existente
            string text1 = "João Subiu no telhado\r\n";
            string text2 = "Sua mãe ficou brava\r\n";

            //Maneira não muito correta
            //string conteudoInicial = File.ReadAllText(caminho5);
            //string conteudoFinal = conteudoInicial + text1 + text2;
            //File.WriteAllText(caminho5, conteudoFinal);

            //Maneira mais correta
            File.AppendAllText(caminho5, text1 + text2);

            //Revisando StreamWriter e StreamReader
            string caminho6 = "Test.txt";
            FileStream fs = File.Create(caminho6);
            fs.Close();

            StreamWriter sw = new StreamWriter(caminho6);
            sw.Write('a');
            sw.Write('-');
            sw.Write("Olá Mundo\r\n");
            sw.WriteLine("Pulando Linha");

            sw.Close();

            StreamReader sr = new StreamReader(caminho6);

            //Criando o Buffer que será preenchido pelo Read
            char[] buffer = new char[128];
            //Apartir do indice 4, 5 caracteres
            sr.Read(buffer, 4, 5);
 
            //Ler uma linha completa
            string linha = sr.ReadLine();

            //Lê o arquivo completo
            string arquivoInteiro = sr.ReadToEnd();
            Console.WriteLine(arquivoInteiro);
            sr.Close();


        }
    }
}

