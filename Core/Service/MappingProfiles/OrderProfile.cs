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
            CreateMap<Order, OrderDto>()
                .ForMember(dist => dist.Status, options => options.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => DateOnly.FromDateTime(src.OrderDate)))
                .ForMember(dist => dist.OrderItems, options => options.MapFrom(src => src.OrderItems))
                .ForMember(dist => dist.PaymentMethod, options => options.MapFrom(src => src.PaymentMethod.ToString()))
                ;
            CreateMap<OrderDto, OrderDto>();
            CreateMap<OrderItemDto, OrderDto>();
        }
    }
}
