using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService
{

    public static List<Product> _products = new List<Product>();
    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }
    public Product GetProductById(string productId)
    {
        return _products.FirstOrDefault(product => product.Id == productId);
    }
    public Product CreateProduct(Product newProduct)
    {

        return newProduct;
    }
    //public Product UpdateProduct(string productId, Product updateProduct)
    //{    
    //    }
    public bool DeleteProduct(string productId)
    {
        var productToRemove = _products.FirstOrDefault(product => product.Id == productId);
        if (productToRemove != null)
        {
            _products.Remove(productToRemove);
            return true;
        }
        return false;
    }


}