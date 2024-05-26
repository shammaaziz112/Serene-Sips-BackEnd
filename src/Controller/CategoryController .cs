using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;

namespace sdaonsite_2_csharp_backend_teamwork.src.Controller;
[Route("api/v1/categories")]
public class CategoryController : BaseController
{
    private ICategoryService _CategoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _CategoryService = categoryService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<CategoryReadDto>> FindAll()
    {
        return Ok(_CategoryService.FindAll());
    }
    [HttpGet("{id}")]
    public ActionResult<CategoryReadDto?> FindOne([FromRoute] Guid id)
    {
        return Ok(_CategoryService.FindOne(id));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CategoryReadDto> CreateOne([FromBody] CategoryCreateDto category)
    {
        if (category is not null)
        {
            var createdUser = _CategoryService.CreateOne(category);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CategoryReadDto> UpdateOne(Guid id, [FromBody] CategoryCreateDto category)
    {

        CategoryReadDto? updatedCategory = _CategoryService.UpdateOne(id, category);
        if (updatedCategory is null) return BadRequest();
        return CreatedAtAction(nameof(UpdateOne), updatedCategory);

    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(Guid id)
    {
        bool isDeleted = _CategoryService.DeleteOne(id);
        if (!isDeleted)

        {
            return NotFound();
        }
        return NoContent();

    }

}