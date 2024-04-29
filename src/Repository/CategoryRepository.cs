using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository
{
    public class CategoryRepository
    {
        IEnumerable <Category> category;
    public CategoryRepository()
    {
        category= new DatabaseContext().Category;
    }
    public IEnumerable<Category> FindAll()
    {
        return category;
    }
    public Category FindOne(Category category)
    {
        return category;
    }

    public Category CreateOne(Category Category)
    {
        return Category;
    }
    public Category UpdateOne(Category Category)
    {
        return Category;
    }
    public IEnumerable<Category> DeleteAll(string id)
    {
        category.Where(category => category.Id == id);
        return category;
    }

        
    }
}