using System.Linq.Expressions;

namespace PurchaseParadise.Core.Specifications;

public class BaseSpecification<T> : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria { get; }
    public List<Expression<Func<T, object>>> Includes { get; }

    public BaseSpecification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
        Includes = new List<Expression<Func<T, object>>>();
    }

    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }
}
