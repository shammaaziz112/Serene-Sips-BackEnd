using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface ICategoryService
    {
        public IEnumerable<CategoryReadDto> FindAll();
        public CategoryReadDto? FindOne(string id);

        public CategoryReadDto CreateOne(Category category);
        public CategoryReadDto? UpdateOne(string name, Category newCategory);
        public bool DeleteOne(string id);

    }
}