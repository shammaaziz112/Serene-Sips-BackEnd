using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface ICategoryService
    {
        public List<OrderItem> FindAll(OrderItem orderitem);
        public OrderItem FindOne(OrderItem orderitem);
        public OrderItem CreateOne(OrderItem orderitem);
        public OrderItem UpdateOne(OrderItem orderitem);
        public OrderItem DeleteOne(string id);

    }
}