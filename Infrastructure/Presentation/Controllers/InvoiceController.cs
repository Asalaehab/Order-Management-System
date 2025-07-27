using Microsoft.AspNetCore.Mvc;
using ServiceAbstraction;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class InvoiceController(IServiceManger _serviceManger) : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<InvoiceDto> GetInvoiceById(int id) 
        { 
          var Invoice=_serviceManger.InvoiceService.GetById(id);
          return Ok(Invoice);
        }

        [HttpGet]
        public ActionResult<IEnumerable<InvoiceDto>> GetInvoiceAll() 
        { 
            var Invoices=_serviceManger.InvoiceService.GetAll();
            return Ok(Invoices);
        }
    }
}
