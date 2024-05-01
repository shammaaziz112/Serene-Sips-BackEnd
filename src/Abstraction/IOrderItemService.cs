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
        public ActionResult<IEnumerable<OrderItem>> FindAll();
        public OrderItem FindOne(string orderItemId);
        public OrderItem CreateOne(OrderItem orderitem);
        public OrderItem UpdateOne(OrderItem orderitem);
        public OrderItem DeleteOne(string id);


    }
}