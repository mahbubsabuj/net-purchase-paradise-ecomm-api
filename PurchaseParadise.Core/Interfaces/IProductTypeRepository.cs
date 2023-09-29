using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Core.Interfaces;

public interface IProductTypeRepository
{
    Task<IReadOnlyList<ProductType>> GetAllProductTypesAsync();
}
