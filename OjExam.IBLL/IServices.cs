using OjExam.Model;

namespace OjExam.IBLL
{
    public partial interface IAdminSetService:IBaseService<AdminSet>
    {
    }
	
    public partial interface IClassService:IBaseService<Class>
    {
    }
	
    public partial interface IClassTeacherCourserService:IBaseService<ClassTeacherCourser>
    {
    }
	
    public partial interface ICourserService:IBaseService<Courser>
    {
    }
	
    public partial interface IExamSetService:IBaseService<ExamSet>
    {
    }
	
    public partial interface IGradeService:IBaseService<Grade>
    {
    }
	
    public partial interface IKnowPointSetService:IBaseService<KnowPointSet>
    {
    }
	
    public partial interface IProblemService:IBaseService<Problem>
    {
    }
	
    public partial interface IStatusSetService:IBaseService<StatusSet>
    {
    }
	
    public partial interface IStudentService:IBaseService<Student>
    {
    }
	
    public partial interface ITeacherService:IBaseService<Teacher>
    {
    }
}