using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity;
public class Product
{
    public string Id { get; set; }
    public string CategoryId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
    public Product(string id, string categoryId, string name, double price, string image, int quantity, string description)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Price = price;
        Image = image;
        Quantity = quantity;
        Description = description;
    }
}
