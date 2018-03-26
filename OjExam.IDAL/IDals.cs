










using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using OjExam.Model;



namespace OjExam.IDAL

{


	public partial interface IAdminDal : IBaseDal<Admin>{}


	public partial interface IClassDal : IBaseDal<Class>{}


	public partial interface IClassTeacherCourserDal : IBaseDal<ClassTeacherCourser>{}


	public partial interface ICourserDal : IBaseDal<Courser>{}


	public partial interface IExamDal : IBaseDal<Exam>{}


	public partial interface IGradeDal : IBaseDal<Grade>{}


	public partial interface IKnowPointDal : IBaseDal<KnowPoint>{}


	public partial interface IProblemDal : IBaseDal<Problem>{}


	public partial interface IStatusDal : IBaseDal<Status>{}


	public partial interface IStudentDal : IBaseDal<Student>{}


	public partial interface ITeacherDal : IBaseDal<Teacher>{}


}