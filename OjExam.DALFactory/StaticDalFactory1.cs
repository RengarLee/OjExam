 
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
   
	
		public static IAdminSetDal GetAdminSetDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".AdminSetDal")
				as IAdminSetDal;
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
	
		public static IExamSetDal GetExamSetDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ExamSetDal")
				as IExamSetDal;
		}
	
		public static IGradeDal GetGradeDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".GradeDal")
				as IGradeDal;
		}
	
		public static IKnowPointSetDal GetKnowPointSetDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".KnowPointSetDal")
				as IKnowPointSetDal;
		}
	
		public static IProblemDal GetProblemDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ProblemDal")
				as IProblemDal;
		}
	
		public static IStatusSetDal GetStatusSetDal()
		{
			return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".StatusSetDal")
				as IStatusSetDal;
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