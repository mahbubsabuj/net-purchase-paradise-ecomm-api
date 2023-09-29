using Microsoft.EntityFrameworkCore;
using PurchaseParadise.Core.Interfaces;
using PurchaseParadise.Core.Models;
using PurchaseParadise.Infrastructure.Data;

namespace PurchaseParadise.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.Include((prop) => prop.ProductBrand).Include((prop) => prop.ProductType).FirstOrDefaultAsync((product) => product.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.Include((prop) => prop.ProductBrand).Include((prop) => prop.ProductType).ToListAsync();
        }
    }
}
