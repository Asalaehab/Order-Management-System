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

        [HttpPost]
        public ActionResult CreateOrder([FromBody]OrderDto orderDto)
        {
            _serviceManger.OrderService.CreateOrder(orderDto);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<OrderDto> GetOrderById(int id)
        {
            var Order=_serviceManger.OrderService.GetOrder(id);
            if(Order is null)
            {
                return NotFound();
            }
            return Ok(Order);
        }


        //Update
        [HttpPut("OrderId")]
        public ActionResult UpdateOrders(int OrderId,[FromBody]string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                return BadRequest("Status cannot be empty.");

            var updated = _serviceManger.OrderService.UpdateOrder(OrderId, status);

            if (!updated)
                throw new Exception();

            return NoContent();

        }
    }
}
