using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Controller;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sdaonsite_2_csharp_backend_teamwork.src.Controller;
public class CategoryController : BaseController
{
    private ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<CategoryReadDto>> FindAll()
    {
        return Ok(_categoryService.FindAll());
    }
    [HttpGet("{id}")]
    public ActionResult<CategoryReadDto?> FindOne(Guid id)
    {
        return Ok(_categoryService.FindOne(id));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CategoryReadDto> CreateOne([FromBody] CategoryCreateDto category)
    {
        if (category is not null)
        {
            var createdCategory = _categoryService.CreateOne(category);
            return CreatedAtAction(nameof(CreateOne), createdCategory);
        }
        return BadRequest();
    }
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CategoryReadDto> UpdateOne(Guid id, [FromBody] Category category)
    {

        CategoryReadDto? updatedCategory = _categoryService.UpdateOne(id, category);
        if (updatedCategory is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedCategory);
        }
        else return BadRequest();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(Guid id)
    {
        bool isDeleted = _categoryService.DeleteOne(id);
        if (!isDeleted)

        {
            return NotFound();
        }
        return NoContent();

    }

}