using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;
    public class AddressRepository : IAddressRepository
    {
         public IEnumerable<Address> Addressess;
    public AddressRepository()
    {

        Addressess = new DatabaseContext().Addressess;
    }
    public IEnumerable<Address> FindAll()
    {
        return Addressess;
    }
    public Address? FindOne(string id)
    {
        Address? address = Addressess.FirstOrDefault(order => order.Id == id);
    

    }
    }