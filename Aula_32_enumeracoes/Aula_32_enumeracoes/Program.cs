using Aula_32_enumeracoes.Entities;
using Aula_32_enumeracoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32_enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo: Ciclo de vida de um pedido
            //Criamos uma nova pasta usando o botão direito, add
            //add folder, nomeamos como Entities, e dentro delas
            //criamos as classes desse programa

            //Tenho que importar da pasta em que criei o tipo
            Order order = new Order{
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversão de string para enumeração (Tem que ser igual ao nome de uma variavel)
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);

            //Conversão de enumeração para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            Console.ReadLine();
        }
    }
}
