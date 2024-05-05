using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity
{
    public class Order
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string AddressId { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { set; get; }
        public Order(string id, string userId, string addressId, string status, DateTime orderDate, double totalPrice)
        {
            Id = id;
            UserId = userId;
            AddressId = addressId;
            Status = status;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }

        public Order() { }
    }
}