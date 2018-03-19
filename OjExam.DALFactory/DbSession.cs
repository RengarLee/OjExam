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
        public static DbContext db
        {
            get {return DbSessionFactory.GetCurrentSession(); }
        }
        
        public static int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
