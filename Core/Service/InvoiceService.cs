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
    public class InvoiceService(IUnitOfWork _unitOfWork,IMapper _mapper) : IInvoiceService
    {
        public IEnumerable<InvoiceDto> GetAll()
        {
           var Invoices=_unitOfWork.GetRepository<Invoice>().GetAll();
            return _mapper.Map<IEnumerable<Invoice>, IEnumerable<InvoiceDto>>(Invoices);
        }

        public InvoiceDto GetById(int id)
        {
           var invoice=_unitOfWork.GetRepository<Invoice>().GetById(id);
           if(invoice is null)
            {
                throw new Exception();
            }
           return _mapper.Map<Invoice,InvoiceDto>(invoice);
        }
    }
}
