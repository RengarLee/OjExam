using OjExam.IDAL;

namespace OjExam.DALFactory
{
    public partial class DbSession :IDbSession
    {   		
		public IAdminSetDal AdminSetDal
		{
			get { return StaticDalFactory.GetAdminSetDal(); }
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
		
		public IExamSetDal ExamSetDal
		{
			get { return StaticDalFactory.GetExamSetDal(); }
		}
		
		public IGradeDal GradeDal
		{
			get { return StaticDalFactory.GetGradeDal(); }
		}
		
		public IKnowPointSetDal KnowPointSetDal
		{
			get { return StaticDalFactory.GetKnowPointSetDal(); }
		}
		
		public IProblemDal ProblemDal
		{
			get { return StaticDalFactory.GetProblemDal(); }
		}
		
		public IStatusSetDal StatusSetDal
		{
			get { return StaticDalFactory.GetStatusSetDal(); }
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