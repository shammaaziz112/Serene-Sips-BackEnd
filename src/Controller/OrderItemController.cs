using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{

    public class OrderItemController : ControllerBase
    {
        private IOrderItemService _orderItemService;


        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderItem>> FindAll()
        {
            return Ok(_orderItemService.FindAll());
        }
        
        [HttpGet("{orderItemId}")]
        public OrderItem FindOne(string orderItemId)
        {
            return _orderItemService.FindOne(orderItemId);
        }
        [HttpPost]
        public OrderItem CreateOne(OrderItem orderitem)
        {
            return orderitem;
        }
        [HttpPatch]
        public OrderItem UpdateOne(OrderItem orderitem)
        {
            return orderitem;
        }
        [HttpDelete("{id}")]
        public void DeleteOne(string id)
        {
        _orderItemService.DeleteOne(id); 
        }

    }
}