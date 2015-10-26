using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Repository.UnitofWork
{
    // MySql and SqlServer has same code base with EF6. So no need of extra child class. Just change the context class and you are good to go
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        #region Create
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Added;
            
            return;
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
                this.Insert(entity);
            return;
        }
        #endregion

        #region Read
        public virtual TEntity Get(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<TEntity> GetAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable<TEntity>();
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize)
        {
            return _dbSet
                .AsQueryable<TEntity>()
                .Skip<TEntity>((pageIndex - 1) * pageSize)
                .Take<TEntity>(pageSize);
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector)
        {
            return _dbSet
                .AsQueryable<TEntity>()
                .OrderBy<TEntity, object>(sortingKeySelector)
                .Skip<TEntity>((pageIndex - 1) * pageSize)
                .Take<TEntity>(pageSize);
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Descending:
                    return _dbSet
                        .AsQueryable<TEntity>()
                        .OrderByDescending<TEntity, object>(sortingKeySelector)
                        .Skip<TEntity>((pageIndex - 1) * pageSize)
                        .Take<TEntity>(pageSize);

                default:
                case SortOrder.Unspecified:
                case SortOrder.Ascending:
                    return _dbSet
                        .AsQueryable<TEntity>()
                        .OrderBy<TEntity, object>(sortingKeySelector)
                        .Skip<TEntity>((pageIndex - 1) * pageSize)
                        .Take<TEntity>(pageSize);
            }
        }

        public IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector)
        {
            return _dbSet
                .AsQueryable<TEntity>()
                .OrderBy<TEntity, TKey>(sortingKeySelector)
                .Skip<TEntity>((pageIndex - 1) * pageSize)
                .Take<TEntity>(pageSize);
        }

        public IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector, SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Descending:
                    return _dbSet
                        .AsQueryable<TEntity>()
                        .OrderByDescending<TEntity, TKey>(sortingKeySelector)
                        .Skip<TEntity>((pageIndex - 1) * pageSize)
                        .Take<TEntity>(pageSize);

                default:
                case SortOrder.Unspecified:
                case SortOrder.Ascending:
                    return _dbSet
                        .AsQueryable<TEntity>()
                        .OrderBy<TEntity, TKey>(sortingKeySelector)
                        .Skip<TEntity>((pageIndex - 1) * pageSize)
                        .Take<TEntity>(pageSize);
            }
        }

        public virtual TEntity Find(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual async Task<TEntity> FindAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual TEntity Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }

        public virtual async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable<TEntity>();
        }

        public virtual int Count()
        {
            return _dbSet
                .AsQueryable<TEntity>()
                .Count<TEntity>();
        }

        public virtual async Task<int> CountAsync()
        {
            return await _dbSet
                .AsQueryable<TEntity>()
                .CountAsync<TEntity>();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet
                .AsQueryable<TEntity>()
                .Count<TEntity>(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet
                .AsQueryable<TEntity>()
                .CountAsync<TEntity>(predicate);
        }
        #endregion

        #region Update
        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Attach(entity);
            return;
        }

        public virtual void UpdateRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                this.Update(entity);
            return;
        }
        #endregion

        #region Delete
        public virtual void Delete(object id)
        {
            TEntity entity = this.Find(id);
            this.Delete(entity);
            return;
        }

        public virtual async Task DeleteAsync(object id)
        {
            TEntity entity = await this.FindAsync(id);
            this.Delete(entity);
            return;
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;           
            return;
        }

        public virtual void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
                this.Delete(entity);
            return;
        }
        #endregion

        #region Unit of Work
        public virtual void Commit()
        {
            _context.SaveChanges();
            return;
        }

        public virtual async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
            return;
        }
        #endregion
    }
}
