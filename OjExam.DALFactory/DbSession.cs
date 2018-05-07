using OjExam.EFDAL;
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
    public partial class DbSession:IDbSession
    {

        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
    }
}
