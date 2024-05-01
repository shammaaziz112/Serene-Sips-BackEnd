using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service
{
    public class OrderService : IOrderService
    {

        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderReposiroty, IConfiguration config)
        {
            _orderRepository = orderReposiroty;
        }
        public IEnumerable<Order> FindAll()
        {
            return _orderRepository.FindAll();
        }
        public Order? FindOne(string orderId)
        {
            return _orderRepository.FindOne(orderId);
        }
        public Order CreateOne(Order order)
        {
            return _orderRepository.CreateOne(order);
        }
        public Order? UpdateOne(string id, Order newOrder)
        {

            Order? updatedOrder = _orderRepository.FindOne(id);
            if (updatedOrder is not null)
            {
                updatedOrder.Status = newOrder.Status;
                return _orderRepository.UpdateOne(updatedOrder);
            }
            else return null;
        }

        public bool DeleteOne(string id)
        {
            return _orderRepository.DeleteOne(id);
        }

    }
}