using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models;
using Service.Specifications;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstraction
{
    public class CustomerService(IUnitOfWork _unitOfWork,IMapper _mapper) : ICustomerService
    {
        public void CreateCustomer(CustomerDto customerDto)
        {
            try
            {
                var customer = _mapper.Map<CustomerDto, Customer>(customerDto);
                _unitOfWork.GetRepository<Customer>().Add(customer);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the customer: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<OrderDto> CustomerOrders(int CusmoterId)
        {
            var specifications=new  CustomerWithOrdersSpecifications(CusmoterId);
           var customer= _unitOfWork.GetRepository<Customer>().GetById(specifications);
            if(customer is not null)
            {
                var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(customer.Orders);
                return ordersDto;
            }
            else
            {
                throw new Exception();
            }
            
        }
    }
}
