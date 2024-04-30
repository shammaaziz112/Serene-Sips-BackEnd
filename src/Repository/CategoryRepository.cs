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
        public IEnumerable<Category> category;
        private IEnumerable<Category> _category;
        public CategoryRepository()
        {
            _category = new DatabaseContext().Category;
        }
        public IEnumerable<Category> FindAll()
        {
            return category;
        }
        public Category? FindOne(string name)
        {
            // remember to check nullable item, if it is null, return null, or else return object
            return _category.FirstOrDefault((item) => item.Name == name);
        }

        public Category CreateOne(Category newCategory)
        {
            _category.Append(newCategory);
            return newCategory;
        }
        public Category UpdateOne(Category UpdateCategory)
        {
            // recording for the way to handle update category


            return UpdateCategory;
        }
        public IEnumerable<Category> DeleteAll(string id)
        {
            category.Where(category => category.Id == id);
            return category;
        }


    }
}