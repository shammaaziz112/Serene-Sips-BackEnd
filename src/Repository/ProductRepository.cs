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
    public Product? FindOne(string id,Product product)
    {
        Product? product1 = Products.FirstOrDefault(product => product.Id == id);
        if (product1 is not null)
        {
            return product1;
        }
        else return null;
    }

    public Product CreateOne(Product product)
    {
        Product.Append(product);
        return product;
    }
    public Product UpdateOne(Product UpdatedProduct)
    {
        var Products = Product.Select(product =>
         {
             if (product.Id != UpdatedProduct.Id)
             {
                 return product;
             }
             return UpdatedProduct;
         });
        Products = Product.ToList();

        return UpdatedProduct;
    }
    public IEnumerable<Product> DeleteAll(string id)
    {
        Products.Where(product => product.Id == id);
        return Products;
    }
}
