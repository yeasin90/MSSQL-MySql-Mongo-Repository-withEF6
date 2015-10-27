using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Repository.Repository
{
    public class PatientRepository : NoSql.Mongo.MongoDBRepository<NoSql.Mongo.Patient>
    {
        public PatientRepository(DbContext context)
            : base(context, "Patients")//, "Users")
        {

        }
    }
}
