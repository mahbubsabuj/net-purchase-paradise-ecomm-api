using Microsoft.EntityFrameworkCore;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;
using PurchaseParadise.Infrastructure.Data;
using SQLitePCL;

namespace PurchaseParadise.Infrastructure.Data.Repositories;

public class ProductTypeRepository : IProductTypeRepository
{
    private readonly ApplicationDbContext _context;

    public ProductTypeRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<ProductType>> GetAllProductTypesAsync()
    {
        return await _context.ProductTypes.ToListAsync();
    }
}
