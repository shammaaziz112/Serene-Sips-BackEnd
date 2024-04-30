using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service;
public class AddressService : IAddressService
{
    public IEnumerable<Address> address;
    public AddressService()
    {
        address = new DatabaseContext.Address
    }
    public IEnumerable<Address> FindAll()
    {
        return address;
    }
    public Address? FindOne(string city)
    {
        Address? address = address.FirstOrDefault((address)address.city == city)
        return address;
    }
    public Address CreateOne(Address address)
    {
        Address.Append(address);
        return address;
    
    public Address? UpdateOne(string country, Address address)
    {
        Address.Select(address => address.country);
        return address;
    }
    public Address? DeleteOne(string street, Address address)
    {
        address.Where(address => address.street == street);
        return address;
    }
}
