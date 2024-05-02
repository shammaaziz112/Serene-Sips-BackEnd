using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

    public interface IOrderItemService
    {
        public IEnumerable<OrderItemReadDto> FindAll();
        public OrderItemReadDto? FindOne(string id);
        public OrderItemReadDto CreateOne(OrderItem orderitem);
        public OrderItemReadDto? UpdateOne(string id, OrderItem orderitem);
        public bool DeleteOne(string id);


    }
