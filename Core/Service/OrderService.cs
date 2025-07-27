using AutoMapper;
using DomainLayer.Contracts;
using DomainLayer.Models;
using DomainLayer.Models.Enums;
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

        //bool validateOrder(Order order)
        //{
        //    decimal totalAmount = 0;
        //    foreach (var item in order.OrderItems)
        //    {
        //        var product = _unitOfWork.GetRepository<Product>().GetById(item.ProductId);

        //        if (product is  null)
        //        {
        //            //throw Exception
        //            return false;
        //        }
        //        if (product.Stock < item.Quantity)
        //        {
        //            var Amount= item.Quantity*item.UnitPrice*(1-item.discount);
        //            totalAmount += Amount;
        //        }
        //        else
        //        {
        //            //throw exception
        //            return false;
        //        }

        //    }
        //    if(totalAmount > 200)
        //    {
        //        order.TotalAmount = totalAmount * 0.90m;
        //    }
        //    else if(totalAmount > 100)
        //    {
        //        order.TotalAmount = totalAmount * 0.95m;
        //    }
        //    else
        //    {
        //        order.TotalAmount = totalAmount;
        //    }

        //        return true;
        //}






        public void CreateOrder(OrderDto order)
        {
           var OrderToCreate=_mapper.Map<OrderDto,Order>(order);
            //if (!validateOrder(OrderToCreate))
            //{
            //    //throw Excetion Order Cannot be created
            //}
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
            if (Order is null)
            {
                //throw Exception
                throw new Exception();
            }
         

                var OrderDto = _mapper.Map<Order, OrderDto>(Order);
                return OrderDto;
         
        }

        public bool UpdateOrder(int OrderId, string status)
        {
            var order = _unitOfWork.GetRepository<Order>().GetById(OrderId);
           
            if (order is null)
            {
              
                return false;
            }
            if (!Enum.TryParse<OrderStatus>(status, true, out var parsedStatus))
            {
               
                return false;
            }
            order.Status = parsedStatus;
            _unitOfWork.SaveChanges();
            return true;

        }
    }
}
