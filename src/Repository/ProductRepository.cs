using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Server;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository : IProductRepository
{
    private IEnumerable<Product> _products { get; set; }
    public ProductRepository()
    {
        _products = new DatabaseContext().Products;
    }
    public IEnumerable<Product> FindAll()
    {
        return _products;
    }
    public Product? FindOne(string id)
    {
        Product? product = _products.FirstOrDefault(product => product.Id == id);
        if (product is not null)
        {
            return product;
        }
        else return null;
    }

    public Product CreateOne(Product product)
    {
        _products.Append(product);
        return product;
    }
    public Product UpdateOne(Product updatedProduct)
    {
        var products = _products.Select(product =>
         {
             if (product.Id != updatedProduct.Id)
             {
                 return product;
             }
             return updatedProduct;
         });
        _products = products;

        return updatedProduct;
    }
    public bool DeleteOne(string id)
    {
        Product? product = FindOne(id);
        if (product is null) return false;

        var products = _products.Where(product => product.Id != id);
        _products = products;
        return true;
    }


}
