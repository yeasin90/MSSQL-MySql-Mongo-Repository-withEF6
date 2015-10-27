using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Data.Entity;
using System.Linq.Expressions;
using WepApi.Repository;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApi.Repository.UnitofWork
{
    public class Patient
    {
        [BsonElement("_id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public string Name { get; set; }
        public int Dosess { get; set; }
    }

    public class Ailment
    {
        public string Name { get; set; }
    }

    public abstract class MongoDBRepository<TEntity> 
    {
        private readonly MongoDbContext _context;

        public MongoDBRepository(MongoDbContext context)
        {
            _context = context;
        }

        public IMongoCollection<TEntity> GetAll()
        {
            //string pluralize = TEntity.
            return _context._database.GetCollection<TEntity>("Patients"); 
        }

        public async Task Insert(TEntity entity)
        {
            IMongoCollection<TEntity> collection = this.GetAll();
            await collection.InsertOneAsync(entity);
        }

        public async Task InsertRange(IEnumerable<TEntity> entities)
        {
            IMongoCollection<TEntity> collection = this.GetAll();
            await collection.InsertManyAsync(entities);
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
