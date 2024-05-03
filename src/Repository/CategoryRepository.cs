using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class CategoryRepository : ICategoryRepository
{
    private IEnumerable<Category> _Categories { get; set; }
    public CategoryRepository()
    {
        _Categories = new DatabaseContext().Category;

    }
    public IEnumerable<Category> FindAll()
    {
        return _Categories;
    }
    public Category? FindOne(string id)
    {

        Category? category = _Categories.FirstOrDefault(category => category.Id == category.Id);
        if (category is not null)
        {
            return category;
        }
        else return null;
    }

    public Category CreateOne(Category newCategory)
    {
        _Categories.Append(newCategory);
        return newCategory;
    }
    public Category UpdateOne(Category UpdateCategory)
    {
        var category = _Categories.Select(category =>
     {
         if (category.Name == UpdateCategory.Name)
         {
             return UpdateCategory;
         }
         return category;
     });
        _Categories = category.ToList();

        return UpdateCategory;
    }

public bool DeleteOne(string id)
{
    Category? category = FindOne(id);
    if (category is null) return false;

    var Category =_Categories.Where(category => category.Id != id);
    _Categories= Category;
    return true;
}}
