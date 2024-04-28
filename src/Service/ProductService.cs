using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService
{
    IEnumerable<Product> products;

    public ProductService()
    {
        products = new DatabaseContext().Products;
    }


    public IEnumerable<Product> FindAll()
    {
        return products;
    }
    public Product FindOne(Product product)
    {
        return products.FirstOrDefault(product => product.Id == product.Id);
    }
    public Product CreateOne(Product Product)
    {

        return Product;
    }
    public Product UpdateOne(string email, Product product)
    {
        return product;
    }
    public IEnumerable<Product> DeleteAll(string id)
    {
        products.Where(product => product.Id == id);
        return products;
    }



}