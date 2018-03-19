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
    class DbSessionFactory
    {
        public static DbContext GetCurrentSession()
        {
            DbContext db = CallContext.GetData("DbSession") as DbContext;
            if (db == null)
            {
                db = new OjExamEntities();
                CallContext.SetData("DbSession", db);
            }

            return db;
        }
    }
}
