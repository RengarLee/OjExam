 
namespace OjExam.IDAL
{
    public partial interface IDbSession
    {   
	 
		IAdminSetDal AdminSetDal { get;}
	 
		IClassDal ClassDal { get;}
	 
		IClassTeacherCourserDal ClassTeacherCourserDal { get;}
	 
		ICourserDal CourserDal { get;}
	 
		IExamSetDal ExamSetDal { get;}
	 
		IGradeDal GradeDal { get;}
	 
		IKnowPointSetDal KnowPointSetDal { get;}
	 
		IProblemDal ProblemDal { get;}
	 
		IStatusSetDal StatusSetDal { get;}
	 
		IStudentDal StudentDal { get;}
	 
		ITeacherDal TeacherDal { get;}
	}
}