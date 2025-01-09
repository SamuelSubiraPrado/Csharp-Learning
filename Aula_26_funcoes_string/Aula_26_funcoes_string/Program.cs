using System;

namespace Aula_26_funcoes_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG";
            Console.WriteLine("Original: " + original);
            //Passar para maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine("To Upper: " + s1);

            //Passar para minusculo
            string s2 = original.ToLower();
            Console.WriteLine("To Lower: " + s2);

            //Apaga os espaços em branco no final da string
            string s3 = original.Trim();
            Console.WriteLine("Trim: " + s3);

            //Função de procura, onde está aquela ocorrencia
            int n1 = original.IndexOf("bc");
            Console.WriteLine("IndexOf('bc'): " + n1);

            //Ultima ocorrencia
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            //Recortar a string apartir de certo ponto
            //1) Uso, cortar apartir da posição x
            string s4 = original.Substring(3);
            Console.WriteLine("Substring(3): " + s4);

            //2) Uso, cortar apartir da posição x, até y caracteres
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring(3,5): " + s5);

            //Substituir a parte de um string por outra
            //1) Uso, substituir um caractere, trocar todo 
            //caractere 'a' pelo 'x'
            string s6 = original.Replace('a', 'x');
            Console.WriteLine("Replace ('a', 'x'): " + s6);

            //Substituir a parte de um string por outra
            //2) Uso, substituir uma string "abc" por "xy"
            string s7 = original.Replace("abc", "xy");
            Console.WriteLine("Replace (\"abc\", \"xy\"): " + s7);

            //Testar se uma string é vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty: " + b1);

            //Testar se uma string é vazia ou é espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            //Split - recortar uma função com base em algo

        }
    }
}
