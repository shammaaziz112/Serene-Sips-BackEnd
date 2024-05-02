
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using AutoMapper;
namespace sda_onsite_2_csharp_backend_teamwork.src.Service;

public class OrderItemService : IOrderItemService
{

    private IOrderItemRepository _orderItemRepository;
    private IMapper _mapper;
    public OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper)
    {
        _orderItemRepository = orderItemRepository;
        _mapper = mapper;
    }
    public IEnumerable<OrderItemReadDto> FindAll()
    {
        var orderItem = _orderItemRepository.FindAll();
        var orderitemRead = orderItem.Select(_mapper.Map<OrderItemReadDto>);
        return orderitemRead;
    }

    public OrderItemReadDto CreateOne(OrderItem orderitem)
    {
        var createdOrderItem = _orderItemRepository.CreateOne(orderitem);
        var OrderItemRead = _mapper.Map<OrderItemReadDto>(orderitem);
        return OrderItemRead;
    }
}
