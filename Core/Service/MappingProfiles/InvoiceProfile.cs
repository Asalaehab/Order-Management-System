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
    public class InvoiceProfile:Profile
    {
        public InvoiceProfile()
        {
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<InvoiceDto, Invoice>();
        }
    }
}
