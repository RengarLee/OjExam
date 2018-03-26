 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OjExam.DALFactory;
using OjExam.EFDAL;
using OjExam.IBLL;
using OjExam.IDAL;
using OjExam.Model;

namespace OjExam.BLL
{	
	public partial class AdminService:BaseService<Admin>,IAdminService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.AdminDal;
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
	
	public partial class ExamService:BaseService<Exam>,IExamService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ExamDal;
        } 
	}
	
	public partial class GradeService:BaseService<Grade>,IGradeService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.GradeDal;
        } 
	}
	
	public partial class KnowPointService:BaseService<KnowPoint>,IKnowPointService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.KnowPointDal;
        } 
	}
	
	public partial class ProblemService:BaseService<Problem>,IProblemService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.ProblemDal;
        } 
	}
	
	public partial class StatusService:BaseService<Status>,IStatusService 
    {
		public override void SetCurrentDal()
        {
            CurrentDal = DbSession.StatusDal;
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