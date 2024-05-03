using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controller;

public class ProductController : BaseController
{
    private IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductReadDto>> FindAll()
    {
        return Ok(_productService.FindAll());
    }

    [HttpGet("{name}")]
    public ActionResult<ProductReadDto?> FindOne([FromRoute] string name)
    {
        ProductReadDto? foundProduct = _productService.FindOne(name);
        return Ok(foundProduct);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<ProductReadDto> CreateOne([FromBody] ProductCreateDto product)
    {
        if (product is not null)
        {
            var createdProduct = _productService.CreateOne(product);
            return CreatedAtAction(nameof(CreateOne), createdProduct);
        }
        return BadRequest();
    }

    [HttpPatch("{name}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<ProductReadDto> UpdateOne(string name, [FromBody] ProductReadDto updatedProduct)
    {
        ProductReadDto? product = _productService.UpdateOne(name, updatedProduct);
        if (product is null) return BadRequest();
        return CreatedAtAction(nameof(UpdateOne), product);
    }

    [HttpDelete("{name}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne([FromRoute] string name)
    {
        bool isDeleted = _productService.DeleteOne(name);
        if (!isDeleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
