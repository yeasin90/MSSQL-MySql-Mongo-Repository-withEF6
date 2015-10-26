using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WepApi.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))] // this attribute is must
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext()
            : base("name=mysqlCon")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
