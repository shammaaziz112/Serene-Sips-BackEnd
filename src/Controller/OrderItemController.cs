using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        IEnumerable<OrderItem> orderitem;

        public  OrderItemController()
    {
        orderitem = new DatabaseContext().OrderItem;
    }


    [HttpGet]
    public IEnumerable<OrderItem> FindAll()
    {
        return orderitem;
    }
    [HttpGet("{OrderItemId}")]
    public OrderItem FindOne(OrderItem orderitem)
    {
        return orderitem;
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
    [HttpDelete]
    public IEnumerable<OrderItem> DeleteAll(string id)
    {
        orderitem.Where(orderitem => orderitem.Id == id);
        return orderitem;
    }
    


    }
}