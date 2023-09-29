using AutoMapper;
using PurchaseParadise.Api.Dto;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Api.Helpers;

public class ProductUrlResolver : IValueResolver<Product, ProductDto, string>
{
    private readonly IConfiguration _configuration;
    public ProductUrlResolver(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
    {
        if (!string.IsNullOrEmpty(source.PictureUrl))
        {
            return source.PictureUrl;
        }
        return null;
    }
}