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
    public class CategoryController : ControllerBase
    {
            IEnumerable<Category> category;

    public  CategoryController()
    {
        category = new DatabaseContext().Category;
    }
    [HttpGet]
    public IEnumerable<Category> FindAll()
    {
        return category;
    }
    [HttpGet("{ProcdutId}")]
    public Category FindOne(Category category)
    {
        return category;
    }
    [HttpPost]
    public Category CreateOne(Category category)
    {
        return category;
    }
    [HttpPatch]
    public Category UpdateOne(Category category)
    {
        return category;
    }
    [HttpDelete]
    public IEnumerable<Category> DeleteAll(string id)
    {
        category.Where(category => category.Id == id);
        return category;
    }
        
    }
