using OjExam.DALFactory;
using OjExam.IBLL;
using OjExam.IDAL;
using OjExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OjExam.BLL
{
    public partial class ClassService : BaseService<Class>,IClassService
    {
        //public override void SetCurrentDal()
        //{
        //    CurrentDal = DbSession.ClassDal;
        //}
    }
}
