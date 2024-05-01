using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;
public class AddressRepository : IAddressRepository
{
    public IEnumerable<Address> Addresses;
    public AddressRepository()
    {

        Addresses = new DatabaseContext().Addresses;
    }
    public IEnumerable<Address> FindAll()
    {
        return Addresses;
    }
    public Address? FindOne(string street)
    {
        Address? address = Addresses.FirstOrDefault(address => address.Street == street);
        return address;
    }
    public Address? CreateOne(Address address)
    {
        Address.Append(address);
        return address;
    }
    public Address? UpdateOne(string country, Address updatedAddress)
    {
        var Address = Addresses.Select(address =>
         {
             if (address.Country == updatedAddress.Country)
             {
                 return updatedAddress;
             }
             return address;
         });
        Address = Addresses.ToList();

        return updatedAddress;
    }
    public Address? DeleteOne(string street, Address address)
    {
       Address? address1 = FindOne(street);
        if (address1 is not null)
        {
            var Address = Addresses.Where(address => address.Street != street);
            Address = Addresses;
            return address;
        }
        return null;
    }
}