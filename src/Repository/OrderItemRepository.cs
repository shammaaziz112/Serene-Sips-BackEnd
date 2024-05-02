using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

    public class OrderItemRepository :IOrderItemRepository
    {
        public IEnumerable<OrderItem> OrderItem { get; set; }

        public OrderItemRepository()
        {
            OrderItem = new DatabaseContext().OrderItems;

        }
        public IEnumerable<OrderItem> FindAll()
        {
            return OrderItem;
        }
        public OrderItem? FindOne(string id)
        {
            return OrderItem.FirstOrDefault((item) => item.Id == id);
        }
        public OrderItem CreateOne(OrderItem orderitem)
        {
            OrderItem.Append(orderitem);
            return orderitem;
        }
        public OrderItem UpdateOne(OrderItem UpdateOrderitem)
        {
            var orderitem = OrderItem.Select(orderitem =>
     {
         if (orderitem.Id == orderitem.Id)
         {
             return UpdateOrderitem;
         }
         return orderitem;
     });
            OrderItem = orderitem.ToList();

            return UpdateOrderitem;
        }
        public bool DeleteOne(string id)
        {
            OrderItem? order = FindOne(id);
            if (order is null) return false;


            var orders = OrderItem.Where(order => order.Id != id);
            OrderItem = orders;
            return true;
        }

    IEnumerable<Order> IOrderRepository.FindAll()
    {
        throw new NotImplementedException();
    }

    Order? IOrderRepository.FindOne(string orderId)
    {
        throw new NotImplementedException();
    }

    public Order CreateOne(Order order)
    {
        throw new NotImplementedException();
    }

    public Order UpdateOne(Order updatedOrder)
    {
        throw new NotImplementedException();
    }

    List<OrderItem> IOrderItemRepository.FindAll()
    {
        throw new NotImplementedException();
    }
}
