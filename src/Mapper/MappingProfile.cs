using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.DTO;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Mapper;

public class MappingProfile : Profile
{
    MappingProfile()
    {
        CreateMap<ProductReadDto, Product>();
        CreateMap<Product, ProductReadDto>();

        CreateMap<OrderDto, Order>();
        CreateMap<Order, OrderDto>();

        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();

        // CreateMap<OrderItemDto, OrderItem>();
        // CreateMap<OrderItem, OrderItemDto>();

        // CreateMap<CategoryDto, Category>();
        // CreateMap<Category, CategoryDto>();

        CreateMap<AddressDto, Address>();
        CreateMap<Address, AddressDto>();

    }
}