﻿using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Core.Interfaces;

public interface IProductRepository
{
    Task<Product?> GetProductByIdAsync(int id);
    Task<IReadOnlyList<Product>> GetProductsAsync();
}
