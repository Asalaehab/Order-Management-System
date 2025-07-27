using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Specifications
{
    class CustomerWithOrdersSpecifications : BaseSpecification<Customer>
    {
        public CustomerWithOrdersSpecifications() : base(null)
        {
            AddInclude(C => C.Orders);
        }
        public CustomerWithOrdersSpecifications(int id):base(C=>C.CustomerId==id)
        {
            AddInclude(C => C.Orders);
            AddInclude(C => C.Orders.Select(O=>O.OrderItems));
            
        }
    }
}
