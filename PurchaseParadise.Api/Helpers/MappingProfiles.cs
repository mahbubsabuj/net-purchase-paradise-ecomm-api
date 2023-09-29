using AutoMapper;
using PurchaseParadise.Api.Dto;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Api.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Product, ProductDto>().
            ForMember((m) => m.ProductType, (o) => o.MapFrom((s) => s.ProductBrand.Name)).
            ForMember((m) => m.ProductType, (o) => o.MapFrom((s) => s.ProductType.Name)).
            ForMember((m) => m.ProductType, (o) => o.MapFrom<ProductUrlResolver>());
    }
}
