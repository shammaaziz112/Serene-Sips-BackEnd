using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
public interface IOrderItemRepository
{
    public IEnumerable<OrderItem> FindAll();
    public OrderItem CreateOne(OrderItem orderitem);

}
