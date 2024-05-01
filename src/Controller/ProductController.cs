using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;
[ApiController]
[Route("api/[controller]")]
public class ProductController : BaseController
{
    private ProductService _productService;
    public ProductController(ProductService productService)
    {
        _productService = productService;
    }
    [HttpGet]
    public IEnumerable<Product> FindAll()
    {
        return _productService.FindAll();//Service 
    }
    [HttpGet("{ProcdutId}")]
    public Product? FindOne(string id)
    {
        Product? foundProduct = Products.FirstOrDefault((product) => product.Id == id);
        return foundProduct;
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Product> CreateOne([FromBody] Product product)
    {
       if (product is not null)
        {
           var createdProduct = _productService.CreateOne(product);
            return CreatedAtAction(nameof(CreateOne), createdProduct);
        }
        return BadRequest();

    }
    [HttpPatch("{name}")]
    public Product UpdateOne(string name)
    {
        Product updatedProduct = _productService.UpdateOne(name);
        return updatedProduct;
    }
    [HttpDelete]
    public IEnumerable<Product> DeleteAll(string id)
    {
        Products.Where(product => product.Id == id);
        return Products;
    }
}
