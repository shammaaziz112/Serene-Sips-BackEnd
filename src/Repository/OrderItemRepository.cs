using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository
{
    public class OrderItemRepository
    {
        IEnumerable<OrderItem> orderitem;

        public OrderItemRepository()
        {
            orderitem = new DatabaseContext().OrderItem;

        }
        public IEnumerable<OrderItem> FindAll()
        {
            return orderitem;
        }
        public OrderItem FindOne(OrderItem orderitem)
        {
            return orderitem;
        }
        public OrderItem CreateOne(OrderItem orderitem)
        {
            return orderitem;
        }
        public OrderItem UpdateOne(OrderItem orderitem)
        {
            return orderitem;
        }
        public IEnumerable<OrderItem> DeleteAll(string id)
    {
        orderitem.Where(orderitem => orderitem.Id == id);
        return orderitem;
    }




    }
}