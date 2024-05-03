using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class OrderItemRepository : IOrderItemRepository
{
    private IEnumerable<OrderItem> _OrderItems { get; set; }

    public OrderItemRepository()
    {
        _OrderItems = new DatabaseContext().OrderItems;

    }
    public IEnumerable<OrderItem> FindAll()
    {
        return _OrderItems;
    }
    public OrderItem? FindOne(string id)
    {
        OrderItem? orderItem = _OrderItems.FirstOrDefault(orderItem => orderItem.Id == id);
        if (orderItem is not null)
        {
            return orderItem;
        }
        else return null;
    }

    public OrderItem CreateOne(OrderItem orderitem)
    {
        _OrderItems.Append(orderitem);
        return orderitem;
    }

    public OrderItem UpdateOne(OrderItem updatedOrderItem)
    {
        var orderItems = _OrderItems.Select(orderItem =>
        {
            if (orderItem.Id == updatedOrderItem.Id)

            {
                return updatedOrderItem;
            }
            return orderItem;
        });
        _OrderItems = orderItems;
        return updatedOrderItem;

    }

    public bool DeleteOne(string id)
    {
        OrderItem? orderItem = FindOne(id);
        if (orderItem is null) return false;

        var orderItems =_OrderItems.Where(orderItem => orderItem.Id != id);
        _OrderItems=orderItems;
        return true;

    }
}