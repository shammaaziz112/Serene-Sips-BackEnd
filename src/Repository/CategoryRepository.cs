using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class CategoryRepository :ICategoryRepository
{
    private IEnumerable<Category> _category { get; set; }
    public CategoryRepository()
    {
        _category = new DatabaseContext().Category;
    }
    public IEnumerable<Category> FindAll()
    {
        return _category;
    }
    public Category? FindOne(string id)
    {
        return _category.FirstOrDefault((item) => item.Name == id);
    }

    public Category CreateOne(Category newCategory)
    {
        _category.Append(newCategory);
        return newCategory;
    }
    public Category UpdateOne(Category UpdateCategory)
    {
        var category = _category.Select(category =>
     {
         if (category.Name == UpdateCategory.Name)
         {
             return UpdateCategory;
         }
         return category;
     });
        _category = category.ToList();

        return UpdateCategory;
    }
    public bool DeleteOne(string id)
    {
        Category? category = FindOne(id);
        if (category is not null) return false;
        {
            var categories =_category.Where(category => category.Id != id);
            _category = categories;
            return true;
        }
    
    }

    public Category CreateOne(OrderItem orderitem)
    {
        throw new NotImplementedException();
    }

    public Category UpdateOne(OrderItem orderitem)
    {
        throw new NotImplementedException();
    }
}



