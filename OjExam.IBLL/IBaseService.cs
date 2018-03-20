using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.IBLL
{
    public interface IBaseService<T> where T:class, new ()
    {
        #region Qurry
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamdba);

        IQueryable<T> GetPageEntities<S>(int pageIndex, int pageSize, out int total, Expression<Func<T, bool>> whereLamdba, Expression<Func<T, S>> orderByLamdba, bool isAsc);

        #endregion

        #region Add Delete Updata
        bool Add(T entity);

        bool Delete(T entity);

        bool Updata(T entity);

        #endregion
    }
}
