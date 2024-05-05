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

    [HttpGet("{orderItemId}")]
    public ActionResult<OrderItemReadDto> FindOne(Guid orderItemId)
    {
        return Ok(_orderItemService.FindOne(orderItemId));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> CreateOne([FromBody] OrderItemReadDto orderItem)
    {


        if (orderItem is not null)
        {
            var createdOrderItem = _orderItemService.CreateOne(orderItem);
            return CreatedAtAction(nameof(CreateOne), createdOrderItem);
        }
        return BadRequest();
    }

    [HttpPatch("{orderItemId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> UpdateOne(Guid orderItemId, [FromBody] OrderItem orderItem)
    {

        OrderItemReadDto? updatedOrderItem = _orderItemService.UpdateOne(orderItemId, orderItem);
        if (updatedOrderItem is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedOrderItem);
        }
        else return BadRequest();
    }

    [HttpDelete("{orderItemId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(Guid orderItemId)
    {
        bool isDeleted = _orderItemService.DeleteOne(orderItemId);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();

    }
}
