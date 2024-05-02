using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sdaonsite_2_csharp_backend_teamwork.src.Controller;
public class CategoryController : ControllerBase
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
    [HttpGet("{CategoryId}")]
    public ActionResult<CategoryReadDto?> FindOne(string id)
    {
        return Ok(_CategoryService.FindOne(id));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CategoryReadDto> CreateOne([FromBody] Category category)
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
    public ActionResult<CategoryReadDto> UpdateOne(string id, [FromBody] Category category)
    {

        CategoryReadDto? updatedCategory =_CategoryService.UpdateOne(id, category);
        if (updatedCategory is not null)
        {
            return CreatedAtAction(nameof(UpdateOne), updatedCategory);
        }
        else return BadRequest();
    }
    
    [HttpDelete("{CategoryId}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult DeleteOne(string id)
    {
        bool isDeleted = _CategoryService.DeleteOne(id);
        if (!isDeleted)

        {
            return NotFound();
        }
        return NoContent();

    }

}