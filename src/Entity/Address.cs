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
// Addresses = [
//             new Address("12356329887","1323243","Spain","Barcelona","san de moo","7789"),
//             new Address("1123598543","1004094","Qatar","Qatar","Alshaki salem","5450"),
//             new Address("1008754242","1228602","Saudi Arabia","Riyadh","MBS Street","2030"),
//         ];
    internal Address? FirstOrDefault(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }

    internal static void Select(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}
