using Microsoft.EntityFrameworkCore;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;
using PurchaseParadise.Infrastructure.Data;

namespace PurchaseParadise.Infrastructure.Data.Repositories;

public class ProductBrandRepository : IProductBrandRepository
{
    private readonly ApplicationDbContext _context;

    public ProductBrandRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<ProductBrand>> GetAllProductBrandsAsync()
    {
        return await _context.ProductBrands.ToListAsync();
    }
}