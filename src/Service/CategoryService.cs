using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service
{
    public class CategoryService : ICategoryService
    {
        private CategoryRepository _CategoryRepository;

        public CategoryService(CategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }
        public IEnumerable<Category> FindAll()
        {
            return _CategoryRepository.FindAll();
        }
        public Category? FindOne(string  id)
        {
            return _CategoryRepository.FindOne(id);
        }
        public Category CreateOne(Category category)
        {
            return _CategoryRepository.CreateOne(category);
        }
        public Category? UpdateOne(string id, Category newCategory)
        {
            Category? updatedOrder = _CategoryRepository.FindOne(id);
            if (updatedOrder is not null)
            {
                updatedOrder.Id = newCategory.Id;
                return _CategoryRepository.UpdateOne(updatedOrder);
            }
            return null;

        }
        public bool DeleteOne(string id)
        {
            return _CategoryRepository.DeleteOne(id);
        }

    }
}