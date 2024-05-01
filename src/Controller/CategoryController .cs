using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
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
    public ActionResult<IEnumerable<Category>> FindAll()
    {
        return Ok(_CategoryService.FindAll());
    }
    [HttpGet("{CategoryId}")]
    public ActionResult<Category?> FindOne(string id)
    {
        return Ok(_CategoryService.FindOne(id));
    }
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Category> CreateOne([FromBody] Category category)
    {
        if (category is not null)
        {
            var createdUser = _CategoryService.CreateOne(category);
            return CreatedAtAction(nameof(CreateOne), createdUser);
        }
        return BadRequest();
    }
    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]//? is it right
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public ActionResult<IEnumerable<Category>> DeleteOne(string id)
    {
        IEnumerable<Category>? orders = _CategoryService.DeleteOne(id);
        if (orders is null)
        {
            return CreatedAtAction(nameof(CreateOne), orders);
        }
        else return BadRequest();



    }



}