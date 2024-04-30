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
        public IEnumerable<OrderItem> orderitem { get; }
        private IEnumerable<OrderItem> _orderitem;

        public OrderItemRepository()
        {
            orderitem = new DatabaseContext().OrderItem;

        }
        public IEnumerable<OrderItem> FindAll()
        {
            return orderitem;
        }
        public OrderItem FindOne(string id)
        {
            return _orderitem.FirstOrDefault((item) => item.Id == id);
        }
        public OrderItem CreateOne(OrderItem orderitem)
        {
            _orderitem.Append(orderitem);
            return orderitem;
        }
        public OrderItem UpdateOne(OrderItem UpdateOrderitem)
        {
            var orderitem = _orderitem.Select(orderitem =>
     {
         if (orderitem.Id == orderitem.Id)
         {
             return UpdateOrderitem;
         }
         return orderitem;
     });
            _orderitem = orderitem.ToList();

            return UpdateOrderitem;
        }
        public IEnumerable<OrderItem> DeleteOne(string id)
        {
            orderitem.Where(orderitem => orderitem.Id == id);
            return orderitem;
        }




    }
}