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
        public IEnumerable<Order> Orders;
        private IOrderRepository _orderReopsitory;
        public OrderService(IOrderRepository orderReposiroty)
        {
            Orders = new DatabaseContext().Orders;
            _orderReopsitory = orderReposiroty;
        }
        public IEnumerable<Order> FindAll()
        {
            return Orders;
        }
        public Order? FindOne(Order order)
        {
            return _orderReopsitory.FindOne(order.Id);
        }
        public Order CreateOne(Order order)
        {
            return order;
        }
        public Order UpdateOne(string id, [FromBody] Order order)
        {

            Orders.Select(order => order.Id);
            Order updatedOrder = _orderReopsitory.UpdateOne(order);
            return updatedOrder;
        }
        public IEnumerable<Order> DeleteOne(string id)
        {
            IEnumerable<Order> order = Orders;
            return order;
        }

    }
}