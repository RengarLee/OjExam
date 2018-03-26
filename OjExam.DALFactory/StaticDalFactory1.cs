 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using OjExam.IDAL;

namespace OjExam.DALFactory
{
    /// <summary>
    /// 由简单工厂转变成了抽象工厂。
    /// 抽象工厂  VS  简单工厂
    /// 
    /// </summary>
    public partial class StaticDalFactory
    {
   
	
		public static IAdminDal GetAdminDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".AdminDal")
				as IAdminDal;
		}
	
		public static IClassDal GetClassDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ClassDal")
				as IClassDal;
		}
	
		public static IClassTeacherCourserDal GetClassTeacherCourserDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ClassTeacherCourserDal")
				as IClassTeacherCourserDal;
		}
	
		public static ICourserDal GetCourserDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".CourserDal")
				as ICourserDal;
		}
	
		public static IExamDal GetExamDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ExamDal")
				as IExamDal;
		}
	
		public static IGradeDal GetGradeDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".GradeDal")
				as IGradeDal;
		}
	
		public static IKnowPointDal GetKnowPointDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".KnowPointDal")
				as IKnowPointDal;
		}
	
		public static IProblemDal GetProblemDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ProblemDal")
				as IProblemDal;
		}
	
		public static IStatusDal GetStatusDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".StatusDal")
				as IStatusDal;
		}
	
		public static IStudentDal GetStudentDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".StudentDal")
				as IStudentDal;
		}
	
		public static ITeacherDal GetTeacherDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".TeacherDal")
				as ITeacherDal;
		}
	}
}