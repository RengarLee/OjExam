using OjExam.IDAL;
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
    public class DbSessionFactory
    {
        //DbSession线程内唯一
        public static IDbSession GetCurrentSession()
        {
            IDbSession db = CallContext.GetData("DbSession") as IDbSession;
            if (db == null)
            {
                db = new DbSession();
                CallContext.SetData("DbSession", db);
            }

            return db;
        }
    }
}
