using AutoMapper;
using FikaCoffeeShop.Core.DTOs;
using FikaCoffeeShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<ProductFeature,ProductFeatureDto>().ReverseMap();
            CreateMap<Basket,BasketDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<OrderItem,OrderItemDto>().ReverseMap();
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<ProductUpdateDto,Product>();
            CreateMap<Product,ProductWithCategoryDto > ();
            CreateMap<Category,CategoryWithProductsDto > ();

        }
    }
}
