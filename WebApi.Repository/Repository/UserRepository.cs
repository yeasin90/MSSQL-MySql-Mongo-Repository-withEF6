using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repository.UnitofWork;

namespace WebApi.Repository.Repository
{
    public class UserRepository : Repository<WepApi.Data.User>//MongoDBRepository<MongoRepository.User>//R//Repository<User>
    {
        public UserRepository(DbContext context)
            : base(context)//, "Patients")//, "Users")
        {

        }
    }
}
