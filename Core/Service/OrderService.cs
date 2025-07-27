using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using ServiceAbstraction;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService(IUnitOfWork _unitOfWork,IMapper _mapper) : IOrderService
    {
        public void CreateOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetAllOrders()
        {
            var Orders=_unitOfWork.GetRepository<Order>().GetAll();
            var OrdersDto=_mapper.Map<IEnumerable<Order>,IEnumerable<OrderDto>>(Orders);
            return OrdersDto;
        }

        public OrderDto GetOrder(int id)
        {
            var Order = _unitOfWork.GetRepository<Order>().GetById(id);
            var OrderDto = _mapper.Map<Order, OrderDto>(Order);
            return OrderDto;
        }

        public void UpdateOrder(int OrderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
