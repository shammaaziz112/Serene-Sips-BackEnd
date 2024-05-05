using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
public interface IOrderItemRepository
{
    public IEnumerable<OrderItem> FindAll();
    public OrderItem? FindOne(Guid id);
    public OrderItem CreateOne(OrderItem orderItem);
    public OrderItem UpdateOne(OrderItem updatedOrderItem);
    public bool DeleteOne(Guid id);

}
