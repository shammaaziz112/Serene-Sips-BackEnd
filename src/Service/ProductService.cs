using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService
{
    public IEnumerable<Product> products;
    private ProductRepository _productRepository;
    public ProductService(ProductRepository productRepository)
    {
        _productRepository = productRepository;
        products = new DatabaseContext().Products;
    }


    public IEnumerable<Product> FindAll(Product product)
    {
        return _productRepository.FindAll();
    }
    public Product FindOne(Product product)
    {
        return _productRepository.FindOne(product);
    }
    public Product CreateOne(Product Product)
    {
        return _productRepository.CreateOne(Product);
    }
    public Product UpdateOne(Product product)
    {
        return _productRepository.UpdateOne(product);
    }
    public IEnumerable<Product> DeleteAll(string id)
    {
        return _productRepository.DeleteAll(id);
    }

}