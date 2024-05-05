using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class OrderRepository : IOrderRepository
{
    private IEnumerable<Order> _orders { get; set; }
    public OrderRepository()
    {
        _orders = new DatabaseContext().Orders;
    }
    public IEnumerable<Order> FindAll()
    {
        return _orders;
    }
    public Order? FindOne(string orderId)
    {
        Order? order = _orders.FirstOrDefault(order => order.Id == orderId);
        if (order is not null) return order;
        return null;
    }
    public Order CreateOne(Order order)
    {
        _orders.Append(order);
        return order;
    }
    public Order UpdateOne(Order updatedOrder)
    {
        var orders = _orders.Select(order =>
         {
             if (order.Id == updatedOrder.Id)
             {
                 return updatedOrder;
             }
             return order;
         });
        _orders = orders;

        return updatedOrder;
    }

    public bool DeleteOne(string id)
    {
        Order? order = FindOne(id);
        if (order is null) return false;

        var orders = _orders.Where(order => order.Id != id);
        _orders = orders;
        return true;
    }
}
