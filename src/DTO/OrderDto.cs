using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTO
{
    public class OrderReadDto
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { set; get; }
    }
}