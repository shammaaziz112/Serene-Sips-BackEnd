
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controllerl;

public class IOrderItemController : BaseController

{
    private IOrderItemService _orderItemService;

    public IOrderItemController(IOrderItemService orderItemService)
    {
        _orderItemService = orderItemService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<OrderItemReadDto>> FindAll()
    {
        return Ok(_orderItemService.FindAll());
    }

    [HttpGet("{OrderItemId}")]
    public ActionResult<OrderItemReadDto> FindOne(string id)
    {
        return Ok(_orderItemService.FindOne(id));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> CreateOne([FromBody] OrderItem orderItem)
    {
        if (orderItem is not null)
        {
            var createdUser = _orderItemService.CreateOne(orderItem);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }

    [HttpPatch("{OrderItemId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> UpdateOne(string id, [FromBody] OrderItem orderitem)
    {

        OrderItemReadDto? updatedOrderItem = _orderItemService.UpdateOne(id, orderitem);
        if (updatedOrderItem is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedOrderItem);
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
