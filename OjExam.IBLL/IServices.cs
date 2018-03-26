 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OjExam.Model;

namespace OjExam.IBLL
{	
    public partial interface IAdminService:IBaseService<Admin>
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
	
    public partial interface IExamService:IBaseService<Exam>
    {
    }
	
    public partial interface IGradeService:IBaseService<Grade>
    {
    }
	
    public partial interface IKnowPointService:IBaseService<KnowPoint>
    {
    }
	
    public partial interface IProblemService:IBaseService<Problem>
    {
    }
	
    public partial interface IStatusService:IBaseService<Status>
    {
    }
	
    public partial interface IStudentService:IBaseService<Student>
    {
    }
	
    public partial interface ITeacherService:IBaseService<Teacher>
    {
    }
}