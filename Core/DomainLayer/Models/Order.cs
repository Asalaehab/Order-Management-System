using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalAmount { get; set; }

        public OrderItem OrderItems { get; set; } = null!;

        public string PaymentMethod { get; set; } = null!;

        public  OrderStatus Status { get; set; }
    }
}
