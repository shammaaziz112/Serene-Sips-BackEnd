using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service
{
    public class CategoryService
    {
        public IEnumerable<Category> category;
        private CategoryRepository _CategoryRepository;

        public CategoryService(CategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
            category = new DatabaseContext().Category;
        }


        public IEnumerable<Category> FindAll(Category category)
        {
            return _CategoryRepository.FindAll();
        }
        public Category FindOne(Category category)
        {
            return  _CategoryRepository.FindOne(category);
        }
        public Category CreateOne(Category category)
        {
            return _CategoryRepository.CreateOne(category);
        }
        public Category UpdateOne(Category category)
        {
            return _CategoryRepository.UpdateOne(category);
        }
        public IEnumerable<Category> DeleteAll(string id)
        {
            return _CategoryRepository.DeleteAll(id);
        }

    }
}