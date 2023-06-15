using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RelockProject.DtoLayer.Dtos.ProductDto;
using RelockProject.EntityLayer.Concrete;

namespace RelockWebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();

            CreateMap<UpdateProductDto, Product>().ReverseMap();
        }
    }
}
