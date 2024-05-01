using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction
{
    public interface IProductrService
    {
        public List<Product> FindAll(Product productr);
        public Product FindOne(Product productr);
        public Product CreateOne(Product productr);
        public Product UpdateOne(Product productr);
        public Product DeleteOne(string id);

    }
}