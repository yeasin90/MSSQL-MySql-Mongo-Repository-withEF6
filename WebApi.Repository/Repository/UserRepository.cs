using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repository.UnitofWork;
using WepApi.Data;

namespace WebApi.Repository.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DbContext context)
            : base(context)
        {

        }

    }
}
