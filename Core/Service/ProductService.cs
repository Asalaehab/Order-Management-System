using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models;
using ServiceAbstraction;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService(IUnitOfWork _unitOfWork, IMapper _mapper) : IProductService
    {
        
        public void AddProduct(ProductDto productDto)
        {
            try
            {
                var produt = _mapper.Map<Product>(productDto);
                _unitOfWork.GetRepository<Product>().Add(produt);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                //throw new Exception("cannot be create", ex.Message);
                //Error
            }
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _unitOfWork.GetRepository<Product>().GetAll();
            return _mapper.Map<IEnumerable<Product>,IEnumerable<ProductDto>>(products);
        }

        public ProductDto GetProductById(int id)
        {
            var Product = _unitOfWork.GetRepository<Product>().GetById(id);
            if (Product is null)
            {
                throw new NotImplementedException();//
            }
            return _mapper.Map<ProductDto>(Product);
        }

        public ProductDto UpdateProduct(UpdateProductDto productdto,int id)
        {

            var product = _unitOfWork.GetRepository<Product>().GetById(id);

            if (product is null)
            {
                throw new NotImplementedException();
            }
            product.Name = productdto.Name;
            product.Price= productdto.Price;
            product.Stock = productdto.Stock;

            _unitOfWork.GetRepository<Product>().Update(product);
            _unitOfWork.SaveChanges();
            return _mapper.Map<ProductDto>(product);
        }
    }
}
