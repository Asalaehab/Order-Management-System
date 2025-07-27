using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class OrderDto
    {
        //public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public DateOnly OrderDate { get; set; }

        //public decimal TotalAmount { get; set; }


        public string PaymentMethod { get; set; } = default!;
        public string Status { get; set; }=default!;

        public List<OrderItemDto> OrderItems { get; set; } = [];

    }
}
