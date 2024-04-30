using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            _OrderItemRepository=orderItemRepository;
            orderitem=new DatabaseContext().OrderItem;


        }
        public IEnumerable<OrderItem> FindAll(OrderItem orderitem)

        {
            return _OrderItemRepository.FindAll();
        }
        public OrderItem FindOne(OrderItem orderitem)
        {
            return _OrderItemRepository.FindOne(orderitem);
        }
        public OrderItem CreateOne(OrderItem orderitem)
        {
            return _OrderItemRepository.CreateOne(orderitem);
        }
        public OrderItem UpdateOne(OrderItem orderitem)
        {
            return _OrderItemRepository.UpdateOne(orderitem);
        }
            public IEnumerable<OrderItem> DeleteAll(string id)
        {
            return  _OrderItemRepository.DeleteAll(id);
        }



    }
}