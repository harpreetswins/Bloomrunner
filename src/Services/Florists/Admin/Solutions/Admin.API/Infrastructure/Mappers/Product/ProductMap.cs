using Admin.Application.DTO.Request;
using Admin.Domain.Models.Admin;
using Admin.Domain.Models.Product;
using AutoMapper;
namespace Admin.API.Infrastructure.Mappers.Product
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<ProductDTO, ProductModel>().ReverseMap();
            // CreateMap<string, List<FloristItems>>().ReverseMap();
        }
    }
}