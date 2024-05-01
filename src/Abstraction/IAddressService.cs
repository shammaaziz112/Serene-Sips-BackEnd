using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IAddressService
{
    public IEnumerable<Address> FindAll();
    public Address? FindOne(string id);
    public Address CreateOne(Address address);
    public Address? UpdateOne(string id, Address address);
    public bool DeleteOne(string id);
}
