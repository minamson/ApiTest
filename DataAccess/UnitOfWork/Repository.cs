using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataAccess.UnitOfWork.Specification;
using N.EntityFramework.Extensions;


namespace DataAccess.UnitOfWork
{

    /// <summary>
    /// Generic repository
    /// </summary>
    public sealed class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext _context;

        private Repository()
        {
        }

        public Repository(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;
        }

        public bool Exist(TEntity entity)
        {
            return _context.Set<TEntity>().Count() > 0 ? true : false;
        }


        public TEntity FindByKey(object keyValue)
        {
            return _context.Set<TEntity>().Find(keyValue);
        }

        public async Task<TEntity> FindAsync(object keyValue)
        {
            return await _context.Set<TEntity>().FindAsync(keyValue);
        }

        public TEntity FindByKey(object[] keyValues)
        {
            return _context.Set<TEntity>().Find(keyValues);
        }

        public async Task<TEntity> FindByKeyAsync(object[] keyValues)
        {
            return await _context.Set<TEntity>().FindAsync(keyValues);
        }

        public IQueryable<TEntity> GetQuery()
        {
            return _context.Set<TEntity>().DefaultIfEmpty().AsQueryable();
        }

        public IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> predicate)
        {
            return GetQuery().Where(predicate);
        }

        public IQueryable<TEntity> GetQuery(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntitiesFrom(GetQuery());
        }

        /// <summary>
        /// 페이지로 조회
        /// </summary>
        public IQueryable<TEntity> FindByPage<TOrderBy>
            (Expression<Func<TEntity, TOrderBy>> orderBy,
                int pageIndex,
                int pageSize,
                SortEnum sortOrder)
        {
            if (sortOrder == SortEnum.Ascending)
            {
                return GetQuery().OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }
            return GetQuery().OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
        }

        /// <summary>
        /// 페이지로 조회
        /// </summary>
        public IQueryable<TEntity> FindByPage<TOrderBy>
            (Expression<Func<TEntity, bool>> criteria,
             Expression<Func<TEntity, TOrderBy>> orderBy,
                int pageIndex,
                int pageSize,
                SortEnum sortOrder)
        {

            if (sortOrder == SortEnum.Ascending)
            {
                return GetQuery(criteria).OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }
            return GetQuery(criteria).OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
        }


        /// <summary>
        /// 페이지로 조회
        /// </summary>
        public IQueryable<TEntity> FindByPage<TOrderBy>
            (ISpecification<TEntity> specification,
                Expression<Func<TEntity, TOrderBy>> orderBy,
                int pageIndex,
                int pageSize,
                SortEnum sortOrder)
        {
            if (sortOrder == SortEnum.Ascending)
            {
                return specification.SatisfyingEntitiesFrom(GetQuery()).OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }
            return specification.SatisfyingEntitiesFrom(GetQuery()).OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
        }

        public TEntity Single(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().Single(criteria);
        }

        public TEntity Single(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntityFrom(GetQuery());
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return GetQuery().First(predicate);
        }

        public TEntity First(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntitiesFrom(GetQuery()).First();
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _context.Set<TEntity>().Add(entity);
            _context.Entry(entity).State = EntityState.Added;
        }


        public void Add(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                Add(item);
            }
        }


        public void AddBulk(IEnumerable<TEntity> entities)
        {
            _context.BulkInsert(entities);
        }

        public void AddBulkAsync(IEnumerable<TEntity> entities)
        {
            _context.BulkInsertAsync(entities);
        }


        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
            _context.Set<TEntity>().Remove(entity);

        }

        public void Delete(Expression<Func<TEntity, bool>> criteria)
        {
            IEnumerable<TEntity> records = FindBy(criteria);
            foreach (TEntity record in records)
            {
                Delete(record);
            }
        }

        public void Delete(ISpecification<TEntity> criteria)
        {
            IEnumerable<TEntity> records = FindBy(criteria);
            foreach (TEntity record in records)
            {
                Delete(record);
            }
        }

        public IQueryable<TEntity> FindAll()
        {
            return GetQuery().AsQueryable();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                Update(item);
            }
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().Where(criteria).AsQueryable();
        }

        public TEntity FindOne(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().Where(criteria).FirstOrDefault();
        }

        public TEntity FindOne(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntityFrom(GetQuery());
        }

        public IQueryable<TEntity> FindBy(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntitiesFrom(GetQuery()).AsQueryable();
        }

        public int Count()
        {
            return GetQuery().ToList().Count;
        }

        public int Count(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().Count(criteria);
        }

        public int Count(ISpecification<TEntity> criteria)
        {
            return criteria.SatisfyingEntitiesFrom(GetQuery()).Count();
        }

        private void Attach(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is Null");
            }

            _context.Set<TEntity>().Attach(entity);
        }

    }
}
