
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controllerl;

public class IOrderItemController : BaseController

{
    private IOrderItemService _orderItemService;

    public IOrderItemController(IOrderItemService orderService)
    {
        _orderItemService = orderService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<OrderItemReadDto>> FindAll()
    {
        return Ok(_orderItemService.FindAll());
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<OrderItemReadDto> CreateOne([FromBody] OrderItem order)
    {
        if (order is not null)
        {
            var createdUser = _orderItemService.CreateOne(order);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }
}
