using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Specifications
{
    internal class OrderWithOrderItemsspecifications : BaseSpecification<Order>
    {
        //Get All Orders
      
        public OrderWithOrderItemsspecifications() : base(null)
        {
            AddInclude(o => o.OrderItems);
        }
        public OrderWithOrderItemsspecifications(int id):base(O=>O.OrderId==id)
        {
            AddInclude(o => o.OrderItems);
        }
    }
}
