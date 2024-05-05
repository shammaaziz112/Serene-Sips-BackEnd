using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class CategoryRepository : ICategoryRepository
{
    private IEnumerable<Category> _categories { get; set; }
    public CategoryRepository()
    {
        _categories = new DatabaseContext().Category;

    }
    public IEnumerable<Category> FindAll()
    {
        return _categories;
    }
    public Category? FindOne(Guid id)
    {

        Category? category = _categories.FirstOrDefault(category => category.Id == category.Id);
        if (category is not null)
        {
            return category;
        }
        else return null;
    }

    public Category CreateOne(Category newCategory)
    {
        _categories.Append(newCategory);
        return newCategory;
    }
    public Category UpdateOne(Category updateCategory)
    {
        var category = _categories.Select(category =>
     {
         if (category.Name == updateCategory.Name)
         {
             return updateCategory;
         }
         return category;
     });
        _categories = category.ToList();

        return updateCategory;
    }

public bool DeleteOne(Guid id)
{
    Category? category = FindOne(id);
    if (category is null) return false;

    var Category =_categories.Where(category => category.Id != id);
    _categories= Category;
    return true;
}}
    







