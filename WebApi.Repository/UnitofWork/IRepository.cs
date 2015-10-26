using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Repository.UnitofWork
{
    public interface IRepository<TEntity>
    {
        //void Commit();
        //Task CommitAsync();
        int Count();
        int Count(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        void Delete(object id);
        Task DeleteAsync(object id);
        void DeleteRange(IEnumerable<TEntity> entities);
        TEntity Find(params object[] keyValues);
        TEntity Find(object id);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FindAsync(params object[] keyValues);
        Task<TEntity> FindAsync(object id);
        TEntity Get(object id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize);
        IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector);
        IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder);
        IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector);
        IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector, SortOrder sortOrder);
        Task<TEntity> GetAsync(object id);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
    }
}
