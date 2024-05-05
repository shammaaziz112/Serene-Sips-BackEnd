using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

public interface IOrderItemService
{
    public IEnumerable<OrderItemReadDto> FindAll();
    public OrderItemReadDto? FindOne(Guid id);

    public OrderItemReadDto CreateOne(OrderItemReadDto orderItem);
    public OrderItemReadDto? UpdateOne(Guid id, OrderItem newOrderItem);

    public bool DeleteOne(Guid id);

}
