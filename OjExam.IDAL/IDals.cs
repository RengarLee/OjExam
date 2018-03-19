










using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using OjExam.Model;



namespace OjExam.IDAL

{


	public partial interface IAdminSetDal : IBaseDal<AdminSet>{}


	public partial interface IClassDal : IBaseDal<Class>{}


	public partial interface IClassTeacherCourserDal : IBaseDal<ClassTeacherCourser>{}


	public partial interface ICourserDal : IBaseDal<Courser>{}


	public partial interface IExamSetDal : IBaseDal<ExamSet>{}


	public partial interface IGradeDal : IBaseDal<Grade>{}


	public partial interface IKnowPointSetDal : IBaseDal<KnowPointSet>{}


	public partial interface IProblemDal : IBaseDal<Problem>{}


	public partial interface IStatusSetDal : IBaseDal<StatusSet>{}


	public partial interface IStudentDal : IBaseDal<Student>{}


	public partial interface ITeacherDal : IBaseDal<Teacher>{}


}