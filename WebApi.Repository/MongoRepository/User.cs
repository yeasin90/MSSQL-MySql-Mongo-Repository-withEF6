using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql.Mongo
{
    public class User : MongoEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
    }
}
