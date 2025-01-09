using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_32_enumeracoes.Entities.Enums
{
    //tipo enum        cada item do enum será do tipo int
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        shipped = 2,
        Delivered = 3
    }
}
