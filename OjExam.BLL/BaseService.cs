using OjExam.DALFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.BLL
{
    public class BaseService<T> where T:class, new ()
    {
    //    public DbSession 

    //    #region Qurry
    //    public T GetEntities(Expression<Func<T, bool>> whereLamdba)
    //    {
    //        //return db.Entry.GetEntities(whereLamdba);
    //        return db.Set<T>().Where<T>(whereLamdba).FirstOrDefault();
    //    }

    //    public IQueryable<T> GetPageEntities<S>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLamdba, Expression<Func<T, S>> orderByLamdba, bool isAsc)
    //    {
    //        return db.Set<T>().Where<T>(whereLamdba).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize).OrderBy<T, S>(orderByLamdba) as IQueryable<T>;
    //    }
    //    #endregion

    //    #region Add Delete Updata
    //    public bool Add(T entity)
    //    {
    //        db.Set<T>().Add(entity);
    //        return true;
    //    }

    //    public bool Delete(T entity)
    //    {
    //        db.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
    //        return true;
    //    }

    //    public bool Updata(T entity)
    //    {
    //        db.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
    //        return true;
    //    }
    //    #endregion
    //}
}
}
