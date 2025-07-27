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
    public class CustomerProfile: Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}
