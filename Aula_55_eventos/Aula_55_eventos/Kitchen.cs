using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_55_eventos
{
    internal class Kitchen
    {
        //Receita para criar um evento

        //1 adicionar um delegate
        public delegate void OrderReadyEventHandler(object source, EventArgsOrderReady e);
        //2 Nome do evento
        public event OrderReadyEventHandler OrderReady;
        //3 Metodo para disparar o evento
        public void SendMessageOrderReady(UInt32 pOrderNumber)
        {
            //Verificar se alguem está escutando ele
            if (OrderReady != null)
            {
                EventArgsOrderReady e = new EventArgsOrderReady(pOrderNumber);
                //Passando pro evento o próprio obj que está sendo chamado para exec esse metodo
                OrderReady(this, e);
            }
        }
    }
}
