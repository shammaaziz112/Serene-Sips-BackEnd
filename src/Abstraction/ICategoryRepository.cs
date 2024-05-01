using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface ICategoryRepository
    {


        
        public IEnumerable<OrderItem> FindAll();
        public OrderItem ? FindOne(string id);
        public OrderItem CreateOne(OrderItem orderitem);
        public OrderItem UpdateOne(OrderItem orderitem);
        public IEnumerable<OrderItem>  DeleteOne(string id);

    }
}