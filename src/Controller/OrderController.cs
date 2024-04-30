using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Service;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllerl;

public class OrderController : BaseController
{
    private IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IEnumerable<Order> FindAll()
    {
        return _orderService.FindAll();
    }

    [HttpGet("{OrderId}")]
    public Order? FindOne(Order order)
    {
        return _orderService.FindOne(order);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Order> CreateOne([FromBody] Order order)
    {
        if (order is not null)
        {
            var createdUser = _orderService.CreateOne(order);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();

    }

    [HttpPatch("{email}")]
    public Order UpdateOne(string id, [FromBody] Order order)
    {
        Order updatedOrder = _orderService.UpdateOne(id, order);
        return updatedOrder;
    }

    [HttpDelete("{id}")]
    public IEnumerable<Order> DeleteOne(string id)
    {
        return _orderService.DeleteOne(id);

    }
}
