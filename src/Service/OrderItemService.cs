
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using AutoMapper;





namespace sda_onsite_2_csharp_backend_teamwork.src.Service;

public class OrderItemService : IOrderItemService
{
    public IEnumerable<OrderItem> orderitem;

    private OrderItemRepository _OrderItemRepository;
    private IMapper _mapper;


    public OrderItemService(OrderItemRepository orderItemRepository, IMapper mapper)
    {
        _OrderItemRepository = orderItemRepository;
        orderitem = new DatabaseContext().OrderItems;
        _mapper = mapper;
    }
    public IEnumerable<OrderItemReadDto> FindAll()
    {
        var orderitem = _OrderItemRepository.FindAll();
        var orderitemRead = orderitem.Select(_mapper.Map<OrderItemReadDto>);
        return orderitemRead;
    }

    public OrderItemReadDto? FindOne(string id)
    {
        OrderItem? orderitem = _OrderItemRepository.FindOne(id);
        OrderItemReadDto? OrderItemRead = _mapper.Map<OrderItemReadDto>(orderitem);
        return OrderItemRead;
    }
    public OrderItemReadDto CreateOne(OrderItem orderitem)
    {
        var createdOrderItem = _OrderItemRepository.CreateOne(orderitem);
        var OrderItemRead = _mapper.Map<OrderItemReadDto>(orderitem);
        return OrderItemRead;
    }
    public OrderItemReadDto? UpdateOne(string id, OrderItem orderitem)
    {
        OrderItem? updatedorderitem =  _OrderItemRepository.FindOne(id);
        if (updatedorderitem is not null)
        {
            updatedorderitem.Id = orderitem.Id;
            var updatedOrderitemid =_OrderItemRepository.UpdateOne(updatedorderitem);
            var updatedOrderitemRead = _mapper.Map<OrderItemReadDto>(updatedOrderitemid);
            return updatedOrderitemRead;
        }
        else return null;

    }




    public bool DeleteOne(string id)
    {
        return _OrderItemRepository.DeleteOne(id);
    }
}
