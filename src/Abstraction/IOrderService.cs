using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IOrderService
    {
        public IEnumerable<Order> FindAll();
        public Order? FindOne(Order order);
        public Order CreateOne(Order order);
        public Order? UpdateOne(string email, Order order);
        public IEnumerable<Order>? DeleteOne(string id);
    }
}