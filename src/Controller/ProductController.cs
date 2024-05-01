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
    [HttpGet("{name}")]
    public Product? FindOne(string name)
    {
        Product? foundProduct = _productService.FindOne(name);
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
    [HttpPatch]
    public Product UpdateOne([FromBody] Product updatedProduct)
    {
        Product product = _productService.UpdateOne(updatedProduct);
        return product;
    }
    [HttpDelete]
    public ActionResult DeleteOne(string id)
    {
        _productService.DeleteOne(id);
        return NoContent();
    }
}
