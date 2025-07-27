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
    public class OrderController(IServiceManger _serviceManger) :ControllerBase
    {
        //GetAllOrders
        [HttpGet()]
        //Get BaseUrl/api/Orders
        public ActionResult<IEnumerable<OrderDto>> GetAllOrders() 
        { 
            var Orders=_serviceManger.OrderService.GetAllOrders();
            return Ok(Orders);
        }
    }
}
