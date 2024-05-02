using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class OrderItemRepository : IOrderItemRepository
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
    public OrderItem CreateOne(OrderItem orderitem)
    {
        OrderItem.Append(orderitem);
        return orderitem;
    }

}