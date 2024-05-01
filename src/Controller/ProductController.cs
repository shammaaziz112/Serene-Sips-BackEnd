using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
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
    public ActionResult<IEnumerable<ProductReadDto>> FindAll()
    {
        return Ok(_productService.FindAll());
    }
    [HttpGet("{name}")]
    public ActionResult<ProductReadDto?> FindOne(string name)
    {
        ProductReadDto? foundProduct = _productService.FindOne(name);
        return Ok(foundProduct);
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<ProductReadDto> CreateOne([FromBody] Product product)
    {
        if (product is not null)
        {
            var createdProduct = _productService.CreateOne(product);
            return CreatedAtAction(nameof(CreateOne), createdProduct);
        }
        return BadRequest();
    }

    [HttpPatch("{ProductId}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<ProductReadDto> UpdateOne(string id, [FromBody] Product updatedProduct)
    {
        ProductReadDto? product = _productService.UpdateOne(id, updatedProduct);
        if (product is null) return BadRequest();
        return CreatedAtAction(nameof(UpdateOne), product);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(string id)
    {
        bool isDeleted = _productService.DeleteOne(id);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
