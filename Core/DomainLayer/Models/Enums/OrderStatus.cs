using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Enums
{
    public enum OrderStatus
    {

        pending = 0,
        paymentRecieved = 1,
        paymentFailed = 2
    }
}
