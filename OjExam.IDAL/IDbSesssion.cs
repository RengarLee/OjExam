 
namespace OjExam.IDAL
{
    public partial interface IDbSession
    {   
	 
		IAdminDal AdminDal { get;}
	 
		IClassDal ClassDal { get;}
	 
		IClassTeacherCourserDal ClassTeacherCourserDal { get;}
	 
		ICourserDal CourserDal { get;}
	 
		IExamDal ExamDal { get;}
	 
		IGradeDal GradeDal { get;}
	 
		IKnowPointDal KnowPointDal { get;}
	 
		IProblemDal ProblemDal { get;}
	 
		IStatusDal StatusDal { get;}
	 
		IStudentDal StudentDal { get;}
	 
		ITeacherDal TeacherDal { get;}
	}
}