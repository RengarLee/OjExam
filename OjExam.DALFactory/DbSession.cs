using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.DALFactory
{
    public class DbSession
    {
        public static DbContext db{ get; set; }
        public static DbContext GetCurrentDbSession() {
            db = CallContext.GetData("DbSession") as DbContext;
            if (db == null)
            {
                db = new OjExamEntities();
                CallContext.SetData("DbSession", db);
            }

            return db;
        }

        public static int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
