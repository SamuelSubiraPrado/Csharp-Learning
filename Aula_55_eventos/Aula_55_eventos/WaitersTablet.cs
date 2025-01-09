using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_55_eventos
{
    internal class WaitersTablet
    {
        private string Name;

        //A assinatura do metodo precisa ser a mesma do delegate criado (Classe Kitchen)
        public void ShowOrderReadyMessage(object source, EventArgsOrderReady e)
        {
            Console.WriteLine("Order " + e.OrderNumber + " is ready in the kitchen: " + Name);
        }

        public WaitersTablet(string name, Kitchen kitchen)
        {
            Name = name;
            //Cadastrar o evento do garçom, quem estiver cadastrado, recebera esse metodo.
            kitchen.OrderReady += ShowOrderReadyMessage;
        }
    }
}
