using System.Linq;


namespace DataAccess.UnitOfWork.Specification
{
    public interface ISpecification<TEntity>
    {
        TEntity SatisfyingEntityFrom(IQueryable<TEntity> query);

        IQueryable<TEntity> SatisfyingEntitiesFrom(IQueryable<TEntity> query);
    }
}
