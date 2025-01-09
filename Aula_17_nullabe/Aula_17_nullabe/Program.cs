using System;

namespace Aula_16_tipo_ref_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable/?(opcional) - Permite que seja atribuido valor nulo a tipos Struct
            //Nullable<double> x = null;
            // ou
            double? x = null;
            double? y = 10.0;

            //Nullable possui 3 métodos principais
            //1)Pega o valor da variavel, ou se não exitir,
            //pega o valor padrão do tipo, no caso de double é 0.00
            Console.WriteLine(x.GetValueOrDefault());
            //Já no y, como ele tem um valor, será impresso o valor
            Console.WriteLine(y.GetValueOrDefault());

            //2)Verifica se dentro da variavel há algum valor, retorna bool
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //3)Lança uma exceção caso a variavel seja nula
            //possível uso:
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X é nulo");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y é nulo");
            }

            //OPERADOR DE COALESCÊNCIA NULA
            //Caso o x seja nulo, você quer jogar(??) outro valor
            //se não for nulo, joga o valor de x
            double z = x ?? 0.0;
            Console.WriteLine(z);
        }
    }
}