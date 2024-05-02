
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;

namespace sda_onsite_2_csharp_backend_teamwork.src.Service
{
    public class CategoryService : ICategoryService
    {
        private CategoryRepository _CategoryRepository;
        private IMapper _mapper;

        public CategoryService(CategoryRepository CategoryRepository, IMapper mapper)
        {
            _CategoryRepository = CategoryRepository;
            _mapper = mapper;
        }
        public IEnumerable<CategoryReadDto> FindAll()
        {
            var categories = _CategoryRepository.FindAll();
            var categoriesRead = categories.Select(_mapper.Map<CategoryReadDto>);
            return categoriesRead;
        }
        public CategoryReadDto? FindOne(string id)
        {
            Category? category = _CategoryRepository.FindOne(id);
            CategoryReadDto? categoryRead = _mapper.Map<CategoryReadDto>(category);
            return categoryRead;
        }
        public CategoryReadDto CreateOne(Category category)
        {
            var createdCatgory = _CategoryRepository.CreateOne(category);
            var categoryRead = _mapper.Map<CategoryReadDto>(category);
            return categoryRead;
        }
        public CategoryReadDto? UpdateOne(string id, Category newCategory)
        {
            Category? updatedCategory = _CategoryRepository.FindOne(id);
            if (updatedCategory is not null)
            {
                updatedCategory.Name = newCategory.Name;
                var updatedCategoryname=_CategoryRepository.UpdateOne(updatedCategory);
                var  updatedCategoryRead =_mapper.Map<CategoryReadDto>(updatedCategoryname);
                return updatedCategoryRead;
            }
             else return null;

        }
        public bool DeleteOne(string id)
        {
            return _CategoryRepository.DeleteOne(id);
        }

    }
}