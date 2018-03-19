using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.IDAL
{
    public interface IBaseDal<T> where T : class, new()
    {
        #region Qurry
        T GetEntities(Expression<Func<T, bool>> whereLamdba);

        IQueryable<T> GetPageEntities<S>(int pageIndex, int pageSize, Expression<Func<T, bool>> whereLamdba, Expression<Func<T, S>> orderByLamdba, bool isAsc);
        #endregion

        #region Add Delete Updata
        int Add(T entity);

        int Delete(T entity);

        int Updata(T entity);

        #endregion
    }
}
