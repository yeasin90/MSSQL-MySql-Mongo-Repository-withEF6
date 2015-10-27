using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql.Mongo
{
    public class MongoDbContext : DbContext
    {
        internal readonly IMongoClient _client;
        internal readonly IMongoDatabase DB;

        public MongoDbContext() 
        {
            _client = new MongoClient("mongodb://localhost");
            DB = _client.GetDatabase("PatientDB");
        }
    }
}
