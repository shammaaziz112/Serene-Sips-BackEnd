using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class OrderRepository : IOrderRepository
{
    private DbSet<Order> _orders { get; set; }
    private DatabaseContext _databaseContext;

    public OrderRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _orders = databaseContext.Orders;
    }
    public IEnumerable<Order> FindAll()
    {
        return _orders;
    }
    public Order? FindOne(string orderId)
    {
        Order? order = _orders.Find(orderId);
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
        _orders.Update(updatedOrder);
        _databaseContext.SaveChanges();
        return updatedOrder;
    }

    public bool DeleteOne(string id)
    {
        Order? order = FindOne(id);
        if (order is null) return false;
        _orders.Remove(order);
        return true;
    }
}
