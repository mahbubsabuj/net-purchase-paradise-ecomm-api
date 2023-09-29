using PurchaseParadise.Core.Models;
using PurchaseParadise.Core.Specifications;

namespace PurchaseParadise.Core.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T?> GetEntityWithSpecification(ISpecification<T> specification);
    Task<IReadOnlyList<T>> GetAllEntityWithSpecification(ISpecification<T> specification);
}
