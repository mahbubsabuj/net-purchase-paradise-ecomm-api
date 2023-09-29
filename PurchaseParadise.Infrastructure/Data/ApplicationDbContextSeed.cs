using PurchaseParadise.Core.Models;
using System.Text.Json;

namespace PurchaseParadise.Infrastructure.Data;

public class ApplicationDbContextSeed
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        if (!context.ProductBrands.Any())
        {
            string brandsData = await File.ReadAllTextAsync("C:\\Users\\mahbu\\practice\\PurchaseParadise\\PurchaseParadise.Infrastructure\\Data\\SeedData\\brands.json");
            List<ProductBrand>? brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

            if (brands != null)
            {
                await context.ProductBrands.AddRangeAsync(brands);
            }
        }

        if (!context.ProductTypes.Any())
        {
            string typesData = await File.ReadAllTextAsync("C:\\Users\\mahbu\\practice\\PurchaseParadise\\PurchaseParadise.Infrastructure\\Data\\SeedData\\types.json");
            List<ProductType>? types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

            if (types != null)
            {
                await context.ProductTypes.AddRangeAsync(types);
            }
        }

        if (!context.Products.Any())
        {
            string productsData = File.ReadAllText("C:\\Users\\mahbu\\practice\\PurchaseParadise\\PurchaseParadise.Infrastructure\\Data\\SeedData\\products.json");
            List<Product>? products = JsonSerializer.Deserialize<List<Product>>(productsData);

            if (products != null)
            {
               await context.Products.AddRangeAsync(products);
            }
        }

        if (context.ChangeTracker.HasChanges())
        {
            await context.SaveChangesAsync();
        }
    }
}
