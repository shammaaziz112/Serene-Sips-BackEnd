using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity
{
    public class OrderItem
    {
        public string Id { get; set; }
        public string Order_Id { get; set; }
        public string Product_Id { get; set; }
        public int Quantity { get; set; }
        public double Unit_Price { get; set; }


        public OrderItem(string id, string order_id, string product_id, int quntity, double unit_price)
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