using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
public class AddressController : BaseController
{
    private IAddressService _addressService;
    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("{id}")]
    public ActionResult<AddressReadDto?> FindOne(string id)
    {
        AddressReadDto? foundAddress = _addressService.FindOne(id);
        return Ok(foundAddress);
    }

    [HttpGet]
    public IEnumerable<AddressReadDto> FindAll()
    {
        return _addressService.FindAll();
    }

    [HttpPost("create")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public AddressReadDto? CreateOne([FromBody] Address address)
    {
        return _addressService.CreateOne(address);
    }
    [HttpPatch("{id}")]
    public ActionResult<AddressReadDto> UpdateOne(string id, Address address)
    {
        AddressReadDto? updatedAddress = _addressService.UpdateOne(id, address);
        if (updatedAddress is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedAddress);
        }
        return BadRequest();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteOne(string id, Address address)
    {
        bool isDeleted = _addressService.DeleteOne(id);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
