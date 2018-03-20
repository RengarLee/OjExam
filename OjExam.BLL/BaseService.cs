using OjExam.DALFactory;
using OjExam.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.BLL
{
    public abstract class BaseService<T> where T : class, new()
    {
        public IBaseDal<T> CurrentDal { get; set; }

        public IDbSession DbSession
        {
            get { return DbSessionFactory.GetCurrentSession(); }
        }

        public abstract void SetCurrentDal();

        public BaseService()
        {
            SetCurrentDal();
        }

        #region Qurry
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamdba)
        {
            return CurrentDal.GetEntities(whereLamdba);
        }

        public IQueryable<T> GetPageEntities<S>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> whereLamdba, Expression<Func<T, S>> orderByLamdba, bool isAsc)
        {
            return CurrentDal.GetPageEntities<S>(pageIndex, pageSize, out total, whereLamdba, orderByLamdba, isAsc);
        }
        #endregion

        #region Add Delete Updata
        public bool Add(T entity)
        {
            CurrentDal.Add(entity);
            return DbSession.SaveChanges()>0;
        }

        public bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return DbSession.SaveChanges() > 0;
        }

        public bool Updata(T entity)
        {
            CurrentDal.Updata(entity);
            return DbSession.SaveChanges() > 0;
        }
        #endregion
    }

}
