using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.UnitOfWork.Specification;

namespace DataAccess.UnitOfWork
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        int Count();
        int Count(ISpecification<TEntity> predicate);
        int Count(Expression<Func<TEntity, bool>> criteria);
        void Delete(ISpecification<TEntity> predicate);
        void Delete(Expression<Func<TEntity, bool>> criteria);
        void Delete(TEntity entity);
        IQueryable<TEntity> FindBy(ISpecification<TEntity> criteria);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> criteria);
        TEntity FindOne(ISpecification<TEntity> predicate);
        TEntity FindOne(Expression<Func<TEntity, bool>> criteria);
        TEntity First(ISpecification<TEntity> predicate);
        TEntity First(Expression<Func<TEntity, bool>> criteria);
        IQueryable<TEntity> FindByPage<TOrderBy>(ISpecification<TEntity> specification, Expression<Func<TEntity, TOrderBy>> orderBy, int pageIndex, int pageSize, SortEnum sortOrder);
        IQueryable<TEntity> FindByPage<TOrderBy>(Expression<Func<TEntity, bool>> criteria, Expression<Func<TEntity, TOrderBy>> orderBy, int pageIndex, int pageSize, SortEnum sortOrder);
        IQueryable<TEntity> FindByPage<TOrderBy>(Expression<Func<TEntity, TOrderBy>> orderBy, int pageIndex, int pageSize, SortEnum sortOrder);
        IQueryable<TEntity> FindAll();
        TEntity FindByKey(object keyValue);
        IQueryable<TEntity> GetQuery();
        IQueryable<TEntity> GetQuery(ISpecification<TEntity> predicate);
        IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> criteria);
        TEntity Single(ISpecification<TEntity> predicate);
        TEntity Single(Expression<Func<TEntity, bool>> criteria);
        void Update(TEntity entity);
    }
}
