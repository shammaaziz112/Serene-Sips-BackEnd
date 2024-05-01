using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class OrderRepository : IOrderRepository
{
    public IEnumerable<Order> Orders {get; set;}
    public OrderRepository()
    {

        Orders = new DatabaseContext().Orders;
    }
    public IEnumerable<Order> FindAll()
    {
        return Orders;
    }
    public Order? FindOne(string orderId)
    {
        Order? order = Orders.FirstOrDefault(order => order.Id == orderId);
        if (order is not null)
        {
            return order;
        }
        else return null;
    }
    public Order CreateOne(Order order)
    {
        Orders.Append(order);
        return order;
    }
    public Order UpdateOne(Order updatedOrder)
    {
        var orders = Orders.Select(order =>
         {
             if (order.Id == updatedOrder.Id)
             {
                 return updatedOrder;
             }
             return order;
         });
        Orders = orders.ToList();

        return updatedOrder;
    }
    public IEnumerable<Order>? DeleteOne(string id)
    {
        Order? order = FindOne(id);
        if (order is not null)
        {
            var orders = Orders.Where(order => order.Id != id);
            Orders = orders;
            return Orders;
        }
        return null;
    }
}
