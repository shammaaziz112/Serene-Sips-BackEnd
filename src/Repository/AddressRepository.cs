using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;
public class AddressRepository : IAddressRepository
{
    public IEnumerable<Address> Addresses { get; set; }
    public AddressRepository()
    {
        Addresses = new DatabaseContext().Addresses;
    }

    public IEnumerable<Address> FindAll()
    {
        return Addresses;
    }

    public Address? FindOne(string id)
    {
        Address? address = Addresses.FirstOrDefault(address => address.Id == id);
        if (address is null) return null;

        return address;
    }
    public Address CreateOne(Address address)
    {
        Addresses.Append(address);
        return address;
    }
    public Address? UpdateOne(Address updatedAddress)
    {
        var Address = Addresses.Select(address =>
         {
             if (address.Country == updatedAddress.Country)
             {
                 return updatedAddress;
             }
             return address;
         });
        Addresses = Address.ToList();
        return updatedAddress;
    }
    public bool DeleteOne(string id)
    {
        Address? address = FindOne(id);
        if (address is null) return false;

        var Address = Addresses.Where(address => address.Id != id);
        Addresses = Address;
        return true;

    }
}