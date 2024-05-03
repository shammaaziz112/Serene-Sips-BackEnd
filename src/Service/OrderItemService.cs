using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using AutoMapper;
namespace sda_onsite_2_csharp_backend_teamwork.src.Service;

public class OrderItemService: IOrderItemService
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

    public OrderItemReadDto? FindOne(string id)
    {
        OrderItem? orderitem = _orderItemRepository.FindOne(id);
        OrderItemReadDto? OrderItemRead = _mapper.Map<OrderItemReadDto>(orderitem);
        return OrderItemRead;
    }
    public OrderItemReadDto CreateOne(OrderItem orderitem)
    {
        var createdOrderItem = _orderItemRepository.CreateOne(orderitem);
        var OrderItemRead = _mapper.Map<OrderItemReadDto>(orderitem);
        return OrderItemRead;
    }
    public OrderItemReadDto? UpdateOne(string id, OrderItem orderitem)
    {
        OrderItem? updatedorderitem =  _orderItemRepository.FindOne(id);
        if (updatedorderitem is not null)
        {
            updatedorderitem.Id = orderitem.Id;
            var updatedOrderitemid =_orderItemRepository.UpdateOne(updatedorderitem);
            var updatedOrderitemRead = _mapper.Map<OrderItemReadDto>(updatedOrderitemid);
            return updatedOrderitemRead;
        }
        else return null;

    }

    public bool DeleteOne(string id)
    {
        return _orderItemRepository.DeleteOne(id);
    }
}

