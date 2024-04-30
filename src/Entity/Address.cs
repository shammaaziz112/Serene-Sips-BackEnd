using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class Address
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Zip_code { get; set; }
    public Address(string id, string user_id, string country, string city, string street, string zip_code)
    {
        Id = id;
        UserId = user_id;
        Country = country;
        City = city;
        Street = street;
        Zip_code = zip_code;
    }
}
