using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class UpdateProductDto
    {
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
