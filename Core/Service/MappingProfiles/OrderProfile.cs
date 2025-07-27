using AutoMapper;
using DomainLayer.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.MappingProfiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<Order,OrderDto>()
                .ForMember(dist=>dist.Status,options=>options.MapFrom(src=>src.Status))
                .ForMember(dist=>dist.OrderItems,options=>options.MapFrom(src=>src.OrderItems));
        }
    }
}
