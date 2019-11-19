using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DTOs;
using EntityModels;

namespace Mapper
{
    public class AutoMapperFunctionality : Profile
    {
        public AutoMapperFunctionality()
        {
            CreateMap<EntityModels.Users, DTOs.User>().ReverseMap();
            CreateMap<EntityModels.Cart, DTOs.Cart>().ReverseMap();
            CreateMap<EntityModels.Product, DTOs.Product>().ReverseMap();
            CreateMap<EntityModels.ProductDetails, DTOs.ProductDetails>().ReverseMap();
            CreateMap<EntityModels.Order, DTOs.Order>().ReverseMap();
        }
    }
}
