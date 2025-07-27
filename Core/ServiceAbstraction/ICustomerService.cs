using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstraction
{
    public interface ICustomerService
    {
        /*
         Create a new customer 
- Get all orders for a customer
         */

        public void CreateCustomer(CustomerDto customer);

        public IEnumerable<OrderDto> CustomerOrders(int CusmoterId);

    }
}
