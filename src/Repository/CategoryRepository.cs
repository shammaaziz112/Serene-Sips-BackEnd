using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class CategoryRepository : ICategoryRepository
{
    private DbSet<Category> _categories { get; set; }
    private DatabaseContext _databaseContext;
    public CategoryRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _categories = _databaseContext.Categories;

    }
    public IEnumerable<Category> FindAll()
    {
        return _categories;
    }
    public Category? FindOne(Guid id)
    {

        Category? category = _categories.FirstOrDefault(category => category.Id == id);
        if (category is null)
        {
            return null;
        }
        return category;
    }

    public Category CreateOne(Category newCategory)
    {
        _categories.Add(newCategory);
        _databaseContext.SaveChanges();
        return newCategory;
    }
    public Category UpdateOne(Category updatedCategory)
    {
        _categories.Update(updatedCategory);
        _databaseContext.SaveChanges();
        return updatedCategory;
    }

    public bool DeleteOne(Guid id)
    {
        Category? foundCategory = FindOne(id);
        if (foundCategory is null) return false;
        _categories.Remove(foundCategory);
        _databaseContext.SaveChanges();
        return true;
    }
}
