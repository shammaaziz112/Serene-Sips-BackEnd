using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

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

    public Product? FindOne(string name)
    {
        Product? product = _products.FirstOrDefault(product => product.Name == name);
        if (product is null)
        {
            return null;
        }
        return product;
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

    public bool DeleteOne(string name)
    {
        Product? foundProduct = FindOne(name);
        if (foundProduct is null) return false;

        var products = _products.Where(product => product.Id != foundProduct.Id);
        _products = products;
        return true;
    }
}
