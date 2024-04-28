using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sdaonsite_2_csharp_backend_teamwork.src.Controller;
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    IEnumerable<Product> products;

    public ProductController()
    {
        products = new DatabaseContext().Products;
    }
    [HttpGet]
    public IEnumerable<Product> FindAll()
    {
        return products;
    }
    [HttpGet("{ProcdutId}")]
    public Product FindOne(Product product)
    {
        return product;
    }
    [HttpPost]
    public Product CreateOne(Product product)
    {
        return product;
    }
    [HttpPatch]
    public Product UpdateOne(string email,Product product)
    {
        return product;
    }
    [HttpDelete]
    public IEnumerable<Product> DeleteAll(string id)
    {
        products.Where(product => product.Id == id);
        return products;
    }
}
