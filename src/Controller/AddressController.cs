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
    [HttpGet("{street}")]
    public Address? FindOne(string street)
    {
        return _addressService.FindOne(street);
    }
    [HttpGet]
    public IEnumerable<Address> FindAll()
    {

        return _addressService.FindAll();
    }
    [HttpPost]
    public Address? CreateOne([FromBody] Address address)
    {
        _addressService.CreateOne(address);
        return address;
    }
    [HttpPatch("{city}")]
    public Address? UpdateOne(string country, Address address)
    {
        _addressService.UpdateOne(country, address);
        return address;
    }
    [HttpDelete("{street}")]
    public Address? DeleteOne(string street, Address address)
    {
        _addressService.DeleteOne(street, address);
        return address;
    }
}
