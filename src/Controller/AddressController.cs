using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
public class AddressController : BaseController
{
    private List<Address> _address;
    public AddressController()
    {
        _address = new DatabaseContext().Address;
    }
    [HttpGet("{street}")]
    public Address? FindOne(string street)
    {
        Address? address = _address.FirstOrDefault((address) => address.Street == street);
        return address;
    }
    [HttpGet]
    public List<Address> FindAll()
    {
        return _address;
    }
    [HttpPost]
    public Address? CreateOne([FromBody] Address address)
    {
        _address.Add(address);
        return address;
    }
    [HttpPatch("{city}")]
    public Address? UpdateOne(string city, Address address)
    {
        _address.Select(address => address.City);
        return address;
    }
    [HttpDelete("{zip_code}")]
    public Address? DeleteOne(string zip_code, Address address)
    {
        _address.Where(address => address.Zip_code == zip_code);
        return address;
    }
}
