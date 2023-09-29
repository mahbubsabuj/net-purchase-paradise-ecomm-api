using Microsoft.EntityFrameworkCore;
using PurchaseParadise.Core.Models;

namespace PurchaseParadise.Core.Specifications;

public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
{
    public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
    {
        IQueryable<TEntity> query = inputQuery;

        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }

        query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));

        return query;
    }
}