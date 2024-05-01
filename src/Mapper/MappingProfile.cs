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

        CreateMap<OrderReadDto, Order>();
        CreateMap<Order, OrderReadDto>();

        CreateMap<UserReadDto, User>();
        CreateMap<User, UserReadDto>();

        CreateMap<OrderItemReadDto, OrderItem>();
        CreateMap<OrderItem, OrderItemReadDto>();

        CreateMap<CategoryReadDto, Category>();
        CreateMap<Category, CategoryReadDto>();

        CreateMap<AddressReadDto, Address>();
        CreateMap<Address, AddressReadDto>();

    }
}