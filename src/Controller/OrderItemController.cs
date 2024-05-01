using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Service;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllerl;

public class IOrderItemController : BaseController

{
    private IOrderItemService _orderItemService;

    public IOrderItemController(IOrderItemService orderService)
    {
        _orderItemService = orderService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<OrderItem>> FindAll()
    {
        return Ok(_orderItemService.FindAll());
    }

    [HttpGet("{OrderItemId}")]
    public ActionResult<OrderItem> FindOne(string orderId)
    {
        return Ok(_orderItemService.FindOne(orderId));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItem> CreateOne([FromBody] OrderItem order)
    {
        if (order is not null)
        {
            var createdUser = _orderItemService.CreateOne(order);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }

    [HttpPatch("{OrderItemId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItem> UpdateOne(string id, [FromBody] Order order)
    {

        OrderItem? updatedOrder = _orderItemService.UpdateOne(id, order);
        if (updatedOrder is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedOrder);
        }
        else return BadRequest();
    }

    [HttpDelete("{OrderItemId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(string id)
    {
        bool isDeleted = _orderItemService.DeleteOne(id);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();

    }
}
