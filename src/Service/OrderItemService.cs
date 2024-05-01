using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;


namespace sda_onsite_2_csharp_backend_teamwork.src.Service
{
    public class OrderItemService
    {
        public IEnumerable<OrderItem> orderitem;
        private OrderItemRepository _OrderItemRepository;

        public OrderItemService(OrderItemRepository orderItemRepository)
        {
            _OrderItemRepository = orderItemRepository;
            orderitem = new DatabaseContext().OrderItems;


        }
        public IEnumerable<OrderItem> FindAll()
        {
            return _OrderItemRepository.FindAll();
        }
        [HttpGet("{orderId}")]

        public OrderItem FindOne(string orderId)
        {
            return _OrderItemRepository.FindOne(orderId);
        }
        public OrderItem CreateOne(OrderItem orderitem)
        {
            return _OrderItemRepository.CreateOne(orderitem);
        }
        public OrderItem UpdateOne(OrderItem orderitem)
        {
            return _OrderItemRepository.UpdateOne(orderitem);
        }
        public bool DeleteAll(string id)
        {
            return _OrderItemRepository.DeleteOne(id);
        }
    }
}