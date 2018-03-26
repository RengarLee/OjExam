 
using OjExam.IDAL;

namespace OjExam.DALFactory
{
    public partial class DbSession :IDbSession
    {   		
		public IAdminDal AdminDal
		{
			get { return StaticDalFactory.GetAdminDal(); }
		}
		
		public IClassDal ClassDal
		{
			get { return StaticDalFactory.GetClassDal(); }
		}
		
		public IClassTeacherCourserDal ClassTeacherCourserDal
		{
			get { return StaticDalFactory.GetClassTeacherCourserDal(); }
		}
		
		public ICourserDal CourserDal
		{
			get { return StaticDalFactory.GetCourserDal(); }
		}
		
		public IExamDal ExamDal
		{
			get { return StaticDalFactory.GetExamDal(); }
		}
		
		public IGradeDal GradeDal
		{
			get { return StaticDalFactory.GetGradeDal(); }
		}
		
		public IKnowPointDal KnowPointDal
		{
			get { return StaticDalFactory.GetKnowPointDal(); }
		}
		
		public IProblemDal ProblemDal
		{
			get { return StaticDalFactory.GetProblemDal(); }
		}
		
		public IStatusDal StatusDal
		{
			get { return StaticDalFactory.GetStatusDal(); }
		}
		
		public IStudentDal StudentDal
		{
			get { return StaticDalFactory.GetStudentDal(); }
		}
		
		public ITeacherDal TeacherDal
		{
			get { return StaticDalFactory.GetTeacherDal(); }
		}
	}
}