using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repository;

public class ProductRepository : IProductRepository
{
    private DbSet<Product> _products { get; set; }
    private DatabaseContext _databaseContext;
    public ProductRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
        _products = databaseContext.Products;
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
        _products.Update(updatedProduct);
        return updatedProduct;
    }

    public bool DeleteOne(string name)
    {
        Product? foundProduct = FindOne(name);
        if (foundProduct is null) return false;
        _products.Remove(foundProduct);
        return true;
    }
}
