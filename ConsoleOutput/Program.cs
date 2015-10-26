using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repository.Repository;
using WepApi.Data;

namespace ConsoleOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMySql();
            //GetSql();
        }

        public static void GetMySql()
        {
            UserRepository rep = new UserRepository(new MySqlDbContext());
            rep.Insert(new User { ID = new Guid("12736219-9398-4DBD-A392-BF8C5CCC3635"), Mobile = "01819421877", Password = "NewPassword", Username = "SiamDeath" });
            rep.Commit();
            //var data = rep.Get(new Guid("C1C8D804-0645-4006-B9C8-192EBD944944"));
            //var collection = rep.GetAll().ToList();
        }

        public static void GetSql()
        {
            UserRepository rep = new UserRepository(new WebApiDBContext());
            rep.Insert(new User { ID = new Guid("19D40AEC-37B7-4114-A5BF-E4E3B3CFC97A"), Mobile = "01819421877", Password = "NewPassword", Username = "SiamDeath" });
            rep.Commit();

            //UserRepository rep = new UserRepository(new WebApiDBContext());
            //var data = rep.Get(new Guid("C1C8D804-0645-4006-B9C8-192EBD944944"));
            //var collection = rep.GetAll().ToList();

        }
    }
}
