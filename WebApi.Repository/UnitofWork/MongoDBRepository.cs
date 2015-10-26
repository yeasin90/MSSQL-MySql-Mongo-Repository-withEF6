using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Data.Entity;
using System.Linq.Expressions;

namespace WebApi.Repository.UnitofWork
{
    public abstract class MongoDBRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public MongoDBRepository()
        {

        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(object id)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllPaged(int pageIndex, int pageSize, Expression<Func<TEntity, object>> sortingKeySelector, SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAllPaged<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> sortingKeySelector, SortOrder sortOrder)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
