using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService : IProductService
{
    public IEnumerable<Product> products;
    private ProductRepository _productRepository;
    public ProductService(ProductRepository productRepository)
    {
        _productRepository = productRepository;
        products = new DatabaseContext().Products;
    }


    public IEnumerable<Product> FindAll()
    {
        return _productRepository.FindAll();
    }
    public Product? FindOne(string name)
    {
        return _productRepository.FindOne(name);
    }
    public Product CreateOne(Product Product)
    {
        return _productRepository.CreateOne(Product);
    }
    public Product UpdateOne(Product product)
    {
        return _productRepository.UpdateOne(product);
    }
    public void DeleteOne(string id)
    {
        _productRepository.DeleteOne(id);
    }

}