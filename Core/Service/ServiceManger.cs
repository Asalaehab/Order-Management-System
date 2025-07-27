using AutoMapper;
using DomainLayer.Contracts;
using ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManger(IUnitOfWork _unitOfWork,IMapper _mapper) : IServiceManger
    {
        private readonly Lazy<IOrderService> _LazyOrderservice=new Lazy<IOrderService>(()=>new OrderService(_unitOfWork,_mapper));
        public IOrderService OrderService => _LazyOrderservice.Value;


        private readonly Lazy<ICustomerService> _CustomerService=new Lazy<ICustomerService>(()=>new CustomerService(_unitOfWork,_mapper));
        public ICustomerService CustomerService => _CustomerService.Value;
    }
}
