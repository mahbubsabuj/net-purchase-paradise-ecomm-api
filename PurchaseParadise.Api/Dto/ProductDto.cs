namespace PurchaseParadise.Api.Dto;

public class ProductDto
{
    public int id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string? PictureUrl { get; set; }
    public required string ProductType { get; set; }
    public required string ProductBrand { get; set; }

}
