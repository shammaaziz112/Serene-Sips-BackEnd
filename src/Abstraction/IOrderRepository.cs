using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> FindAll();
        public Order? FindOne(string orderId);
        public Order CreateOne(Order order);
        public Order UpdateOne(Order updatedOrder);
        public bool DeleteOne(string id);
    }
}