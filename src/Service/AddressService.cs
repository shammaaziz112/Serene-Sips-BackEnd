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
    public IEnumerable<Address> Address;
    public AddressService()
    {
        Address = new DatabaseContext().Addresses;
    }
    public IEnumerable<Address> FindAll()
    {
        return Address;
    }
    public Address? FindOne(string street)
    {
        Address? foundAddress = Address.FirstOrDefault((address) => address.Street == street);
        return foundAddress;
    }
    public Address CreateOne(Address address)
    {
        Address.Append(address);
        return address;
    }
    public Address? UpdateOne(string country, Address address)
    {
        Address.Select(address => address.Country);
        return address;
    }
    public Address? DeleteOne(string street, Address address)
    {
        Address.Where(address => address.Street == street);
        return address;
    }
}
