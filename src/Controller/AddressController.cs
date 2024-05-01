using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
public class AddressController : BaseController
{
    private IAddressService _addressService;
    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("{AddressId}")]
    public ActionResult<Address?> FindOne(string id)
    {
        return Ok(_addressService.FindOne(id));
    }

    [HttpGet]
    public IEnumerable<Address> FindAll()
    {
        return _addressService.FindAll();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public Address? CreateOne([FromBody] Address address)
    {
        _addressService.CreateOne(address);
        return address;
    }
    [HttpPatch("{city}")]
    public ActionResult<Address> UpdateOne(string id, Address address)
    {
        Address? updatedAddress = _addressService.UpdateOne(id, address);
        if (updatedAddress is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedAddress);
        }
        return BadRequest();
    }

    [HttpDelete("{street}")]
    public ActionResult DeleteOne(string id, Address address)
    {
        bool isDeleted = _addressService.DeleteOne(id);
        if (! isDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
