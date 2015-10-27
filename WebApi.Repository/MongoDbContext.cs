using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WepApi.Repository
{
    public class MongoDbContext : DbContext
    {
        internal readonly IMongoClient _client;
        internal readonly IMongoDatabase _database;

        public MongoDbContext() 
        {
            _client = new MongoClient("mongodb://localhost");
            _database = _client.GetDatabase("NameOfYourDatabase");
        }
    }
}
