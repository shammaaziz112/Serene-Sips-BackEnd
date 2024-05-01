using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstraction;
using sda_onsite_2_csharp_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;
using sda_onsite_2_csharp_backend_teamwork.src.Repository;

namespace sda_onsite_2_csharp_backend_teamwork.src.Server;

public class ProductService : IProductService
{
    private ProductRepository _productRepository;
    private IMapper _mapper;
    public ProductService(ProductRepository productRepository, IMapper mapper)
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
    public ProductReadDto CreateOne(Product Product)
    {
        var product = _productRepository.CreateOne(Product);
        var productRead = _mapper.Map<ProductReadDto>(product);
        return productRead;
    }
    public ProductReadDto UpdateOne(Product product)
    {
        var productAllInfo = _productRepository.UpdateOne(product);
        var productRead = _mapper.Map<ProductReadDto>(productAllInfo);
        return productRead;
    }
    public void DeleteOne(string id)
    {
        _productRepository.DeleteOne(id);
    }

}