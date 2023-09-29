using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Core.Interfaces;

public interface IProductBrandRepository
{
    Task<IReadOnlyList<ProductBrand>> GetAllProductBrandsAsync(); 
}
