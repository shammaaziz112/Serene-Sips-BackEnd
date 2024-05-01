using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IProductService
    {
        public IEnumerable<Product> FindAll();
        public Product? FindOne(string name);
        public Product CreateOne(Product product);
        public Product UpdateOne(Product product);
        public void DeleteOne(string id);

    }
}