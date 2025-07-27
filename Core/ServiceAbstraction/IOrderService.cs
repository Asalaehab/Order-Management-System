using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstraction
{
    public interface IOrderService
    {
        // - Get all Ordrers 
        IEnumerable<OrderDto> GetAllOrders();

        //Get details of a specific Order 
        OrderDto GetOrder(int id);

        //- Add a new Order 
        void CreateOrder(OrderDto order);

        //Update Order details 
        bool UpdateOrder(int OrderId,string status);
    }
}
