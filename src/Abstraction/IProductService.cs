using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IProductService
    {
        public IEnumerable<ProductReadDto> FindAll();
        public ProductReadDto? FindOne(string name);
        public ProductReadDto CreateOne(ProductCreateDto product);
        public ProductReadDto? UpdateOne(string id, ProductReadDto updatedReadProduct);
        public bool DeleteOne(string id);

    }
}