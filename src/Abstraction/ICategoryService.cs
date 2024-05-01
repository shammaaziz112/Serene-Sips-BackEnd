using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface ICategoryService
    {
        public IEnumerable<Category> FindAll();
        public Category? FindOne(Category category);

        public Category CreateOne(Category category);

        public Category? UpdateOne(string id, Category newCategory);
        public IEnumerable<Category>? DeleteOne(string id);

    }
}