using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sdaonsite_2_csharp_backend_teamwork.src.Controller;

public class ProductController : ControllerBase
{
    public IEnumerable<Product> Products;

    public ProductController()
    {
        Products = new DatabaseContext().Products;
    }
    [HttpGet]
    public IEnumerable<Product> FindAll()
    {
        return Products;
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
    public Product UpdateOne(string email, Product product)
    {
        return product;
    }
    [HttpDelete]
    public IEnumerable<Product> DeleteAll(string id)
    {
        Products.Where(product => product.Id == id);
        return Products;
    }
}
