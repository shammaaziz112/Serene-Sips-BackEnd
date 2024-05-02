using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
public interface IOrderItemRepository
{
    public List<OrderItem> FindAll();
    public OrderItem? FindOne(string id);
    public OrderItem CreateOne(OrderItem orderitem);
    public OrderItem UpdateOne(OrderItem orderitem);
    public bool DeleteOne(string id);

}
