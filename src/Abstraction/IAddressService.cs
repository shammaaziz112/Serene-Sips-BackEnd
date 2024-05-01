using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IAddressService
{
    public IEnumerable<Address> FindAll();
    public Address? FindOne(string street);
    public Address CreateOne(Address address);
    public Address? UpdateOne(string country, Address address);
    public Address? DeleteOne(string street, Address address);
}
