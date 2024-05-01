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
        public Order? FindOne(Order order)
        {
            return _orderRepository.FindOne(order.Id);
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
                updatedOrder.Id = newOrder.Id;
                return _orderRepository.UpdateOne(updatedOrder);
            }
            return null;

            // Orders.Select(order => order.Id);
            // Order updatedOrder = _orderReopsitory.UpdateOne(order);
            // return updatedOrder;
        }
        public IEnumerable<Order>? DeleteOne(string id)
        {
            return _orderRepository.DeleteOne(id);
        }

    }
}