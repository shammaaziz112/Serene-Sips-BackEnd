using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllerl;

public class OrderController : BaseController
{
    public IEnumerable<Order> Orders;
    public OrderController()
    {
        Orders = new DatabaseContext().Orders;
    }
    [HttpGet]
    public IEnumerable<Order> FindAll()
    {
        return;
    }
    [HttpGet("{OrderId}")]
    public Order FindOne(Order order)
    {
        return;
    }
    [HttpPost]
    public Order CreateOne(Order order)
    {
        return;
    }
    [HttpPatch]
    public Order UpdateOne(string email, Order order)
    {
        return;
    }
    [HttpDelete]
    public IEnumerable<Order> DeleteAll(string id)
    {
        return;
    }
}
