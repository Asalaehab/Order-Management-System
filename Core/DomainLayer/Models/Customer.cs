using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public Order Orders { get; set; }
    }
}
