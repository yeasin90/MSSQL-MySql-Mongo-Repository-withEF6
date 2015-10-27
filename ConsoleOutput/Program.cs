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
            //GetMySql();
            //GetSql();
            GetMongo();
        }

        public async static void GetMongo()
        {
            PatientRepository rep = new PatientRepository(new NoSql.Mongo.MongoDbContext());
            var x = rep.GetAll();
            /*
            await rep.InsertRange(new List<NoSql.Mongo.Patient>
            {
                new NoSql.Mongo.Patient
                {
                    Name = "Yeasin",
                    Ailments = new List<NoSql.Mongo.Ailment> { new NoSql.Mongo.Ailment { Name = "Yeasin Ailments" } },
                    Medications = new List<NoSql.Mongo.Medication> { new NoSql.Mongo.Medication { Name = "Yeasin Medication", Dosess = 10 } }
                },
                new NoSql.Mongo.Patient
                {
                    Name = "Shakil",
                    Ailments = new List<NoSql.Mongo.Ailment> { new NoSql.Mongo.Ailment { Name = "Shakil Ailments" } },
                    Medications = new List<NoSql.Mongo.Medication> { new NoSql.Mongo.Medication { Name = "Shakil Medications", Dosess = 20 } }
                },
                new NoSql.Mongo.Patient
                {
                    Name = "Nishan",
                    Ailments = new List<NoSql.Mongo.Ailment> { new NoSql.Mongo.Ailment { Name = "Nishan"} },
                    Medications = new List<NoSql.Mongo.Medication> { new NoSql.Mongo.Medication { Name = "Nishan Medications ", Dosess = 40  } }
                }
            });*/
        }

        public static void GetMySql()
        {
            UserRepository rep = new UserRepository(new MySqlDbContext());
            rep.Insert(new User { ID = new Guid("12736219-9398-4DBD-A392-BF8C5CCC3635"), Mobile = "01819421877", Password = "NewPassword", Username = "SiamDeath" });
            rep.Commit();
            var data = rep.Get(new Guid("C1C8D804-0645-4006-B9C8-192EBD944944"));
            var collection = rep.GetAll().ToList();
        }

        public static void GetSql()
        {
            UserRepository rep = new UserRepository(new WebApiDBContext());
            rep.Insert(new User { ID = new Guid("19D40AEC-37B7-4114-A5BF-E4E3B3CFC97A"), Mobile = "01819421877", Password = "NewPassword", Username = "SiamDeath" });
            rep.Commit();

            var data = rep.Get(new Guid("C1C8D804-0645-4006-B9C8-192EBD944944"));
            var collection = rep.GetAll().ToList();

        }
    }
}
