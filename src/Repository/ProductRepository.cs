using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository
{
    public IEnumerable<Product> Products;
    public ProductRepository()
    {
        Products = new DatabaseContext().Products;
    }
    public IEnumerable<Product> FindAll()
    {
        return Products;
    }
    public Product FindOne(Product product)
    {
        return product;
    }

    public Product CreateOne(Product product)
    {
        return product;
    }
    public Product UpdateOne(Product product)
    {
        return product;
    }
    public IEnumerable<Product> DeleteAll(string id)
    {
        Products.Where(product => product.Id == id);
        return Products;
    }

}
