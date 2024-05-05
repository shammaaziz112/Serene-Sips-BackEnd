using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid Order_Id { get; set; }
        public Guid Product_Id { get; set; }
        public int Quantity { get; set; }
        public double Unit_Price { get; set; }


        public OrderItem(Guid id, Guid order_id, Guid product_id, int quntity, double unit_price)
        {
            Id = id;
            Order_Id = id;
            Product_Id = product_id;
            Quantity = quntity;
            Unit_Price = unit_price;


        }
        public OrderItem() { }
    }
}