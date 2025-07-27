using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstraction
{
    public interface IProductService
    {
        public IEnumerable<ProductDto> GetAllProducts();
        
        public ProductDto GetProductById(int id);

        public void AddProduct(ProductDto product);
        public ProductDto UpdateProduct(ProductDto product);
    }
}
