using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.EFDAL
{
    public class BaseDal<T> where T : class, new()
    {
        //线程内唯一
        public DbContext Db
        {
            get { return DbContextFactory.GetCurrentDbContext(); }
        }
        
        #region Qurry
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamdba)
        {
            return Db.Set<T>().Where<T>(whereLamdba).AsQueryable();
        }

        public IQueryable<T> GetPageEntities<S>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> whereLamdba, Expression<Func<T, S>> orderByLamdba, bool isAsc)
        {
            total = Db.Set<T>().Count();
            if (isAsc) {
                return Db.Set<T>().Where<T>(whereLamdba).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize).OrderBy<T, S>(orderByLamdba).AsQueryable();
            } else
            {
                return Db.Set<T>().Where<T>(whereLamdba).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize).OrderByDescending<T, S>(orderByLamdba).AsQueryable();
            }
        }
        #endregion

        #region Add Delete Updata
        public bool Add(T entity)
        {
            Db.Set<T>().Add(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            Db.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
            return true;
        }

        public bool Updata(T entity)
        {
            Db.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            return true;
        }
        #endregion
    }
}
