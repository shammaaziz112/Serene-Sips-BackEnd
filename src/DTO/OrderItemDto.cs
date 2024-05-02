using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTO;
public class OrderItemReadDto
{
    public string Id { get; set; }
    public int Quantity { get; set; }
    public double Unit_Price { get; set; }

}
