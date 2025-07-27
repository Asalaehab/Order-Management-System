using Microsoft.AspNetCore.Mvc;
using ServiceAbstraction;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController(IServiceManger _serviceManger) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetAllProducts()
        {
            var products = _serviceManger.ProductService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProductId(int id)
        {
            var Product = _serviceManger.ProductService.GetProductById(id);
            return Ok(Product);
        }

        [HttpPost]
        public ActionResult AddProduct(ProductDto product)
        {

            _serviceManger.ProductService.AddProduct(product);
            return Ok();

        }

        [HttpPut("{productId}")]
        public ActionResult UpdateProduct(int productId)
        {
            var product = _serviceManger.ProductService.GetProductById(productId);
            var productdto = _serviceManger.ProductService.UpdateProduct(product);
            return Ok(productdto);
        }
    }
}
