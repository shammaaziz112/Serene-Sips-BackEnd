using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IOrderItemService
    {
        public IEnumerable<OrderItem> FindAll();
        public OrderItem FindOne(string orderItemId);
        public OrderItem CreateOne(OrderItem orderitem);
        public OrderItem UpdateOne(OrderItem orderitem);
        public bool DeleteAll(string id);
        OrderItem? UpdateOne(string id, Order order);
        bool DeleteOne(string id);
    }
}