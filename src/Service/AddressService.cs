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
    private IAddressRepository _addressRepository;
    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }
    public IEnumerable<Address> FindAll()
    {
        return _addressRepository.FindAll();
    }
    public Address? FindOne(string id)
    {
        return _addressRepository.FindOne(id);
    }
    public Address CreateOne(Address address)
    {
        return _addressRepository.CreateOne(address);
    }
    public Address? UpdateOne(string id, Address address)
    {
        Address? updatedAddress = _addressRepository.FindOne(id);
        if (updatedAddress is not null)
        {
            updatedAddress.Country = address.Country;

            return _addressRepository.UpdateOne(updatedAddress);
        }
        return null;
    }
    public bool DeleteOne(string id)
    {
        return _addressRepository.DeleteOne(id);
    }
}
