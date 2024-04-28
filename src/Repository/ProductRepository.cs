using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository 
{
    IEnumerable<Product> products;
    public ProductRepository()
    {
        products = new DatabaseContext().Products;
    }
    public IEnumerable<Product> FindAll()
    {
        return products;
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
        products.Where(product => product.Id == id);
        return products;
    }

}
