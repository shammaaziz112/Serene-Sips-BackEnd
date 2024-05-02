using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;
    private IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public IEnumerable<ProductReadDto> FindAll()
    {
        var products = _productRepository.FindAll();
        var productRead = products.Select(_mapper.Map<ProductReadDto>);
        return productRead;
    }
    public ProductReadDto? FindOne(string name)
    {
        Product? product = _productRepository.FindOne(name);
        ProductReadDto? productRead = _mapper.Map<ProductReadDto>(product);
        return productRead;
    }
    public ProductReadDto CreateOne(Product product)
    {
        var createdProduct = _productRepository.CreateOne(product);
        var productRead = _mapper.Map<ProductReadDto>(createdProduct);
        return productRead;
    }
    public ProductReadDto? UpdateOne(string id, Product newproduct)
    {
        Product? updatedProduct = _productRepository.FindOne(id);
        if (updatedProduct is not null)
        {
            updatedProduct.Name = newproduct.Name;
            updatedProduct.Price = newproduct.Price;
            updatedProduct.Quantity = newproduct.Quantity;
            updatedProduct.Image = newproduct.Image;
            updatedProduct.Description = newproduct.Description;

            var productAllInfo = _productRepository.UpdateOne(updatedProduct);
            var productRead = _mapper.Map<ProductReadDto>(productAllInfo);
            return productRead;
        }
        else return null;


    }
    public bool DeleteOne(string id)
    {
        return _productRepository.DeleteOne(id);
    }

}