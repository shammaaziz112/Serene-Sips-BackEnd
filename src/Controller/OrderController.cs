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
    public ActionResult<IEnumerable<Order>> FindAll()
    {
        return Ok(_orderService.FindAll());
    }

    [HttpGet("{OrderId}")]
    public ActionResult<Order?> FindOne(string orderId)
    {
        return Ok(_orderService.FindOne(orderId));
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

    [HttpPatch("{OrderId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Order> UpdateOne(string id, [FromBody] Order order)
    {

        Order? updatedOrder = _orderService.UpdateOne(id, order);
        if (updatedOrder is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedOrder);
        }
        else return BadRequest();
    }

    [HttpDelete("{OrderId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(string id)
    {
        bool isDeleted = _orderService.DeleteOne(id);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();

    }
}
