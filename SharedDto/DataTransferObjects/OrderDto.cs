using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalAmount { get; set; }


        public string PaymentMethod { get; set; } = null!;
        public string Status { get; set; }=default!;

        public List<OrderItemDto> OrderItems { get; set; } = [];

    }
}
