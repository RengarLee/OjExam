 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OjExam.DALFactory;
using OjExam.IBLL;
using OjExam.IDAL;
using OjExam.Model;

namespace OjExam.BLL
{	
	public partial class AdminSetService:BaseService<AdminSet>,IAdminSetService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.AdminSetDal;
        } 
	}
	
	public partial class ClassService:BaseService<Class>,IClassService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ClassDal;
        } 
	}
	
	public partial class ClassTeacherCourserService:BaseService<ClassTeacherCourser>,IClassTeacherCourserService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ClassTeacherCourserDal;
        } 
	}
	
	public partial class CourserService:BaseService<Courser>,ICourserService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.CourserDal;
        } 
	}
	
	public partial class ExamSetService:BaseService<ExamSet>,IExamSetService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ExamSetDal;
        } 
	}
	
	public partial class GradeService:BaseService<Grade>,IGradeService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.GradeDal;
        } 
	}
	
	public partial class KnowPointSetService:BaseService<KnowPointSet>,IKnowPointSetService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.KnowPointSetDal;
        } 
	}
	
	public partial class ProblemService:BaseService<Problem>,IProblemService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ProblemDal;
        } 
	}
	
	public partial class StatusSetService:BaseService<StatusSet>,IStatusSetService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.StatusSetDal;
        } 
	}
	
	public partial class StudentService:BaseService<Student>,IStudentService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.StudentDal;
        } 
	}
	
	public partial class TeacherService:BaseService<Teacher>,ITeacherService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.TeacherDal;
        } 
	}
}