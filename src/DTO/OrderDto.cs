using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTO
{
    public class OrderReadDto
    {//??? is it needed?
        public string Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { set; get; }
    }
    public class OrderCreateDto
    {
        public string UserId { get; set; }
        public string AddressId { get; set; }
        public string Status { get; set; }
        public double TotalPrice { set; get; }
    }
}