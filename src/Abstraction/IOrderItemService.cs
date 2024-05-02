using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;

using AutoMapper;


namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IOrderItemService
    {
        public IEnumerable<OrderItemReadDto> FindAll();
        public OrderItemReadDto? FindOne(string id);
        public OrderItemReadDto CreateOne(OrderItem orderitem);
        public OrderItemReadDto? UpdateOne(string id, OrderItem orderitem);
            public bool DeleteOne(string id);


    }
}