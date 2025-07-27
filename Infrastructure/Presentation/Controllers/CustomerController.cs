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
    public class CustomerController(IServiceManger _serviceManger): ControllerBase
    {
        [HttpPost]
        public ActionResult CreateCustomer(CustomerDto customerDto)
        {
            _serviceManger.CustomerService.CreateCustomer(customerDto);
            return Ok();
        }

        [HttpGet("{customerId}orders")]
        public ActionResult GetCustomerOrders(int customerId)
        {
            var Orders = _serviceManger.CustomerService.CustomerOrders(customerId);
            if (Orders == null)
            {

            }
            return Ok(Orders);
        }

    }
}
